namespace CheckAsRunForRoundingError
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFileInDir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numDate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(25, 38);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(564, 20);
            this.tbDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Below is the directory with has directories of channel names , inside are logs ca" +
    "lled DAY_01.txt, DAY_02.txt ....";
            // 
            // btnFileInDir
            // 
            this.btnFileInDir.Location = new System.Drawing.Point(595, 37);
            this.btnFileInDir.Name = "btnFileInDir";
            this.btnFileInDir.Size = new System.Drawing.Size(125, 20);
            this.btnFileInDir.TabIndex = 2;
            this.btnFileInDir.Text = "Select Files in Directory";
            this.btnFileInDir.UseVisualStyleBackColor = true;
            this.btnFileInDir.Click += new System.EventHandler(this.btnFileInDir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 263);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // numDate
            // 
            this.numDate.Location = new System.Drawing.Point(466, 68);
            this.numDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDate.Name = "numDate";
            this.numDate.Size = new System.Drawing.Size(45, 20);
            this.numDate.TabIndex = 4;
            this.numDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDate.ValueChanged += new System.EventHandler(this.numDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter DAY to skip checking, you don\'t want to be checking and writing at the same" +
    " time.";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFile.ForeColor = System.Drawing.Color.Red;
            this.lbFile.Location = new System.Drawing.Point(521, 70);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(55, 13);
            this.lbFile.TabIndex = 6;
            this.lbFile.Text = "DAY_1.txt";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(590, 66);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(79, 20);
            this.btnToday.TabIndex = 7;
            this.btnToday.Text = "Set As Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(675, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(45, 30);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Report hh:mm out of order";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(182, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Search For Specific Phrase:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(353, 99);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(235, 20);
            this.tbSearch.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(595, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 19);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Copy All to Clipboard";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 399);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFileInDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirectory);
            this.Name = "Form1";
            this.Text = "Check As Run Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFileInDir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSave;
    }
}

