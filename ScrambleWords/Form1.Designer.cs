namespace ScrambleWords
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
            this.txt_Word = new System.Windows.Forms.TextBox();
            this.lbl_EnterLetters = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Word
            // 
            this.txt_Word.Location = new System.Drawing.Point(16, 29);
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(100, 20);
            this.txt_Word.TabIndex = 0;
            // 
            // lbl_EnterLetters
            // 
            this.lbl_EnterLetters.AutoSize = true;
            this.lbl_EnterLetters.Location = new System.Drawing.Point(13, 13);
            this.lbl_EnterLetters.Name = "lbl_EnterLetters";
            this.lbl_EnterLetters.Size = new System.Drawing.Size(86, 13);
            this.lbl_EnterLetters.TabIndex = 1;
            this.lbl_EnterLetters.Text = "Enter your letters";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(138, 26);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "GO!";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 73);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.lbl_EnterLetters);
            this.Controls.Add(this.txt_Word);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Word;
        private System.Windows.Forms.Label lbl_EnterLetters;
        private System.Windows.Forms.Button btn_Go;
    }
}

