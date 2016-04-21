using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckAsRunForRoundingError
{
    public partial class Form1 : Form
    {
        #region form functions
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Saving Settings on Form Closing
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckAsRunForRoundingError.Properties.Settings.Default.DefaultDir = tbDirectory.Text;
            CheckAsRunForRoundingError.Properties.Settings.Default.Search = tbSearch.Text;
            CheckAsRunForRoundingError.Properties.Settings.Default.Save();
        }
        //
        // When Form is being shown set title to version and set the default dir
        //
        private void Form1_Shown(object sender, EventArgs e)
        {
            // This automatically puts the version number in the title bar of the first form
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Check As Run Files {0}", version);
            // Set the Text for Default directory
            tbDirectory.Text = CheckAsRunForRoundingError.Properties.Settings.Default.DefaultDir;
            tbSearch.Text = CheckAsRunForRoundingError.Properties.Settings.Default.Search;
            DateTime saveNow = DateTime.Now;
            numDate.Value = saveNow.Day;
        }
        #endregion

        #region non-file processing functions
        private void btnFileInDir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int iCount = 0;
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    if (iCount == 0)
                        tbDirectory.Text = Path.GetDirectoryName(fileName);
                    else iCount++;

                }
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime saveNow = DateTime.Now;
            numDate.Value = saveNow.Day;
        }

        private void numDate_ValueChanged(object sender, EventArgs e)
        {
            lbFile.Text = "DAY_" + numDate.Value.ToString() + ".txt";
        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // check if day matches date
                DateTime saveNow = DateTime.Now;
                if (!(numDate.Value == saveNow.Day))
                    if (MessageBox.Show("Date Doesn't match today, do you want to continue?",
                        "We don't want to check file, while it's being written to by As Run service.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                // Send Message of checking Directory
                richTextBox1.Text = "Now checking " + tbDirectory.Text + " for .txt Files not named " + lbFile.Text + "\r\n=====================================\r\n\r\n";
                btnSave.Enabled = true;
                // check for files in the folders
                DirectoryInfo di = new DirectoryInfo(tbDirectory.Text);
                var directories = di.GetFiles("*.txt", SearchOption.AllDirectories);

                foreach (FileInfo d in directories)
                {
                    if (d.Name == lbFile.Text)
                    {
                        richTextBox1.Text += "Skipping file named " + d.FullName + "\r\n";
                        continue;
                    }
                    // report hh:mm out of order
                    if (radioButton1.Checked == true) ZProcessDFile(d.FullName);
                    // search for phrase
                    else ZSearchDFile(d.FullName);
                }
            }
            catch (Exception  err)
            {
                richTextBox1.Text = "ERROR: " + err.Message + " at " + err.TargetSite;
            }
        }

        private void ZSearchDFile(string filename)
        {
            richTextBox1.Text += "Opening " + filename + " for searching.\r\n------------------------------------------\r\n";
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            string strLine;
            int icounter = 0;
            while ((strLine = file.ReadLine()) != null)
            {
                if(strLine.IndexOf(tbSearch.Text)>=0)
                {
                    richTextBox1.Text += "Found at line " + icounter.ToString() + "\r\n";
                    richTextBox1.Text += strLine + "\r\n";
                }
                icounter++;
            }
            //richTextBox1.Text += strLine + "\r\n";
            richTextBox1.Text += "lines in file " + icounter.ToString() + "\r\n\r\n";
            file.Close();

        }

        private void ZProcessDFile(string filename)
        {
            richTextBox1.Text += "Opening " + filename + " for reading.\r\n------------------------------------------\r\n";
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            string strLine,strTemp;
            int icounter = 0, iNowHour = 0, iNowMinute = 0, iPrevHour = 0, iPrevMinute = 0;
            while ((strLine = file.ReadLine()) != null)
            {
                // I'm converting hours after hyphen and minutes after hyphen to values
                strTemp = strLine.Substring(strLine.IndexOf('-') + 4, 2);
                int.TryParse(strLine.Substring(strLine.IndexOf('-') + 1, 2), out iNowHour);
                int.TryParse(strLine.Substring(strLine.IndexOf('-') + 4, 2), out iNowMinute);
                //
                // if now minutes are < than now previous minutes and now hour is <= previous hour to current hour we have an error
                //
                if ((iNowMinute < iPrevMinute)&&(iNowHour <= iPrevHour))
                {
                    richTextBox1.Text += "ERROR at line" + icounter.ToString() + "\r\n";
                    richTextBox1.Text += strLine + "\r\n";
                }
                icounter++;
                // saving string for next compare
                iPrevHour = iNowHour;
                iPrevMinute = iNowMinute;
            }
            //richTextBox1.Text += strLine + "\r\n";
            richTextBox1.Text += "lines in file " + icounter.ToString() + "\r\n\r\n";
            file.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(richTextBox1.Text);
        }

    }
}
