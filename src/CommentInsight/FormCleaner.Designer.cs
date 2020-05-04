namespace CommentCleanTool
{
    partial class FormCleaner
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CommentOptions = new System.Windows.Forms.Button();
            this.radioButton2_notAscii = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1_all = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1_Start = new System.Windows.Forms.Button();
            this.progressBar_Clean = new System.Windows.Forms.ProgressBar();
            this.button2_Stop = new System.Windows.Forms.Button();
            this.textBox1_FileNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3_CleanCommentLines = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1_CleanFilesNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CurrentFile = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_CommentOptions);
            this.groupBox1.Controls.Add(this.radioButton2_notAscii);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton1_all);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comment Options";
            // 
            // button_CommentOptions
            // 
            this.button_CommentOptions.Location = new System.Drawing.Point(81, 73);
            this.button_CommentOptions.Name = "button_CommentOptions";
            this.button_CommentOptions.Size = new System.Drawing.Size(101, 30);
            this.button_CommentOptions.TabIndex = 21;
            this.button_CommentOptions.Text = "Options...";
            this.button_CommentOptions.UseVisualStyleBackColor = true;
            this.button_CommentOptions.Click += new System.EventHandler(this.Button_CommentOptions_Click);
            // 
            // radioButton2_notAscii
            // 
            this.radioButton2_notAscii.AutoSize = true;
            this.radioButton2_notAscii.Location = new System.Drawing.Point(66, 52);
            this.radioButton2_notAscii.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2_notAscii.Name = "radioButton2_notAscii";
            this.radioButton2_notAscii.Size = new System.Drawing.Size(161, 16);
            this.radioButton2_notAscii.TabIndex = 20;
            this.radioButton2_notAscii.Text = "&Search Comment by Regex";
            this.radioButton2_notAscii.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Clean:";
            // 
            // radioButton1_all
            // 
            this.radioButton1_all.AutoSize = true;
            this.radioButton1_all.Checked = true;
            this.radioButton1_all.Location = new System.Drawing.Point(66, 21);
            this.radioButton1_all.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1_all.Name = "radioButton1_all";
            this.radioButton1_all.Size = new System.Drawing.Size(89, 16);
            this.radioButton1_all.TabIndex = 19;
            this.radioButton1_all.TabStop = true;
            this.radioButton1_all.Text = "&All Comment";
            this.radioButton1_all.UseVisualStyleBackColor = true;
            // 
            // button1_Start
            // 
            this.button1_Start.Location = new System.Drawing.Point(131, 206);
            this.button1_Start.Name = "button1_Start";
            this.button1_Start.Size = new System.Drawing.Size(130, 34);
            this.button1_Start.TabIndex = 1;
            this.button1_Start.Text = "Start";
            this.button1_Start.UseVisualStyleBackColor = true;
            this.button1_Start.Click += new System.EventHandler(this.Button1_Start_Click);
            // 
            // progressBar_Clean
            // 
            this.progressBar_Clean.Location = new System.Drawing.Point(12, 168);
            this.progressBar_Clean.Name = "progressBar_Clean";
            this.progressBar_Clean.Size = new System.Drawing.Size(488, 23);
            this.progressBar_Clean.TabIndex = 2;
            this.progressBar_Clean.Value = 10;
            // 
            // button2_Stop
            // 
            this.button2_Stop.Enabled = false;
            this.button2_Stop.Location = new System.Drawing.Point(277, 206);
            this.button2_Stop.Name = "button2_Stop";
            this.button2_Stop.Size = new System.Drawing.Size(130, 34);
            this.button2_Stop.TabIndex = 1;
            this.button2_Stop.Text = "&Pause";
            this.button2_Stop.UseVisualStyleBackColor = true;
            this.button2_Stop.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1_FileNum
            // 
            this.textBox1_FileNum.Location = new System.Drawing.Point(106, 21);
            this.textBox1_FileNum.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_FileNum.Name = "textBox1_FileNum";
            this.textBox1_FileNum.ReadOnly = true;
            this.textBox1_FileNum.Size = new System.Drawing.Size(99, 21);
            this.textBox1_FileNum.TabIndex = 12;
            this.textBox1_FileNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Files:";
            // 
            // textBox3_CleanCommentLines
            // 
            this.textBox3_CleanCommentLines.Location = new System.Drawing.Point(106, 76);
            this.textBox3_CleanCommentLines.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3_CleanCommentLines.Name = "textBox3_CleanCommentLines";
            this.textBox3_CleanCommentLines.ReadOnly = true;
            this.textBox3_CleanCommentLines.Size = new System.Drawing.Size(99, 21);
            this.textBox3_CleanCommentLines.TabIndex = 13;
            this.textBox3_CleanCommentLines.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Clean Lines:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3_CleanCommentLines);
            this.groupBox2.Controls.Add(this.textBox1_CleanFilesNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1_FileNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(263, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 109);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clean Statics";
            // 
            // textBox1_CleanFilesNum
            // 
            this.textBox1_CleanFilesNum.Location = new System.Drawing.Point(106, 49);
            this.textBox1_CleanFilesNum.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_CleanFilesNum.Name = "textBox1_CleanFilesNum";
            this.textBox1_CleanFilesNum.ReadOnly = true;
            this.textBox1_CleanFilesNum.Size = new System.Drawing.Size(99, 21);
            this.textBox1_CleanFilesNum.TabIndex = 12;
            this.textBox1_CleanFilesNum.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clean Files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "File:";
            // 
            // label_CurrentFile
            // 
            this.label_CurrentFile.AutoSize = true;
            this.label_CurrentFile.Location = new System.Drawing.Point(54, 145);
            this.label_CurrentFile.Name = "label_CurrentFile";
            this.label_CurrentFile.Size = new System.Drawing.Size(23, 12);
            this.label_CurrentFile.TabIndex = 15;
            this.label_CurrentFile.Text = "...";
            // 
            // FormCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 258);
            this.Controls.Add(this.label_CurrentFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar_Clean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_Stop);
            this.Controls.Add(this.button1_Start);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clean Comment...";
            this.Load += new System.EventHandler(this.FormCleaner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1_Start;
        private System.Windows.Forms.ProgressBar progressBar_Clean;
        private System.Windows.Forms.Button button2_Stop;
        private System.Windows.Forms.RadioButton radioButton2_notAscii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1_all;
        private System.Windows.Forms.TextBox textBox1_FileNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3_CleanCommentLines;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CurrentFile;
        private System.Windows.Forms.TextBox textBox1_CleanFilesNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CommentOptions;
    }
}