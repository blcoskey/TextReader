namespace TextReaderGUI
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMostFrequentWord = new System.Windows.Forms.TextBox();
            this.tbMostFrequent7LetterWord = new System.Windows.Forms.TextBox();
            this.tbHighestScoredWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbHighestScoredWord);
            this.panel1.Controls.Add(this.tbMostFrequent7LetterWord);
            this.panel1.Controls.Add(this.tbMostFrequentWord);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbFilePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 224);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Highest Scored Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Most Frequent 7 letter Word";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(698, 16);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Most Frequent Word";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(617, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(6, 16);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(605, 20);
            this.tbFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // tbMostFrequentWord
            // 
            this.tbMostFrequentWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMostFrequentWord.Location = new System.Drawing.Point(6, 86);
            this.tbMostFrequentWord.Name = "tbMostFrequentWord";
            this.tbMostFrequentWord.ReadOnly = true;
            this.tbMostFrequentWord.Size = new System.Drawing.Size(605, 20);
            this.tbMostFrequentWord.TabIndex = 6;
            // 
            // tbMostFrequent7LetterWord
            // 
            this.tbMostFrequent7LetterWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMostFrequent7LetterWord.Location = new System.Drawing.Point(6, 135);
            this.tbMostFrequent7LetterWord.Name = "tbMostFrequent7LetterWord";
            this.tbMostFrequent7LetterWord.ReadOnly = true;
            this.tbMostFrequent7LetterWord.Size = new System.Drawing.Size(605, 20);
            this.tbMostFrequent7LetterWord.TabIndex = 7;
            // 
            // tbHighestScoredWord
            // 
            this.tbHighestScoredWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbHighestScoredWord.Location = new System.Drawing.Point(6, 183);
            this.tbHighestScoredWord.Name = "tbHighestScoredWord";
            this.tbHighestScoredWord.ReadOnly = true;
            this.tbHighestScoredWord.Size = new System.Drawing.Size(605, 20);
            this.tbHighestScoredWord.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Text Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMostFrequentWord;
        private System.Windows.Forms.TextBox tbHighestScoredWord;
        private System.Windows.Forms.TextBox tbMostFrequent7LetterWord;
    }
}

