namespace LicenseExam
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbRightAnswers = new System.Windows.Forms.ListBox();
            this.lbWrongAnswers = new System.Windows.Forms.ListBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.ofdLoadResults = new System.Windows.Forms.OpenFileDialog();
            this.gbRightAnswers = new System.Windows.Forms.GroupBox();
            this.gbWrongAnswers = new System.Windows.Forms.GroupBox();
            this.gbResult.SuspendLayout();
            this.gbRightAnswers.SuspendLayout();
            this.gbWrongAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 225);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(109, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbRightAnswers
            // 
            this.lbRightAnswers.FormattingEnabled = true;
            this.lbRightAnswers.Location = new System.Drawing.Point(6, 19);
            this.lbRightAnswers.Name = "lbRightAnswers";
            this.lbRightAnswers.Size = new System.Drawing.Size(71, 95);
            this.lbRightAnswers.TabIndex = 2;
            // 
            // lbWrongAnswers
            // 
            this.lbWrongAnswers.FormattingEnabled = true;
            this.lbWrongAnswers.Location = new System.Drawing.Point(6, 19);
            this.lbWrongAnswers.Name = "lbWrongAnswers";
            this.lbWrongAnswers.Size = new System.Drawing.Size(71, 95);
            this.lbWrongAnswers.TabIndex = 3;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Location = new System.Drawing.Point(12, 12);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(172, 68);
            this.gbResult.TabIndex = 4;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(6, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(160, 41);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdLoadResults
            // 
            this.ofdLoadResults.DefaultExt = "txt";
            this.ofdLoadResults.FileName = "openFileDialog1";
            this.ofdLoadResults.Filter = "Text files(*.txt)|*.txt";
            this.ofdLoadResults.Title = "Load results file";
            // 
            // gbRightAnswers
            // 
            this.gbRightAnswers.AutoSize = true;
            this.gbRightAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRightAnswers.Controls.Add(this.lbRightAnswers);
            this.gbRightAnswers.Location = new System.Drawing.Point(12, 86);
            this.gbRightAnswers.Name = "gbRightAnswers";
            this.gbRightAnswers.Size = new System.Drawing.Size(83, 133);
            this.gbRightAnswers.TabIndex = 5;
            this.gbRightAnswers.TabStop = false;
            this.gbRightAnswers.Text = "Right:";
            // 
            // gbWrongAnswers
            // 
            this.gbWrongAnswers.AutoSize = true;
            this.gbWrongAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbWrongAnswers.Controls.Add(this.lbWrongAnswers);
            this.gbWrongAnswers.Location = new System.Drawing.Point(101, 86);
            this.gbWrongAnswers.Name = "gbWrongAnswers";
            this.gbWrongAnswers.Size = new System.Drawing.Size(83, 133);
            this.gbWrongAnswers.TabIndex = 6;
            this.gbWrongAnswers.TabStop = false;
            this.gbWrongAnswers.Text = "Wrong:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLoadFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(196, 262);
            this.Controls.Add(this.gbWrongAnswers);
            this.Controls.Add(this.gbRightAnswers);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer Checker";
            this.gbResult.ResumeLayout(false);
            this.gbRightAnswers.ResumeLayout(false);
            this.gbWrongAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gbRightAnswers;
        private System.Windows.Forms.GroupBox gbWrongAnswers;

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbRightAnswers;
        private System.Windows.Forms.ListBox lbWrongAnswers;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.OpenFileDialog ofdLoadResults;

        #endregion
    }
}