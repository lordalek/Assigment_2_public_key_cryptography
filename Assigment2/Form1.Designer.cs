namespace Assigment2
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
            this.btnGenerateRandomPrimeNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDecimals = new System.Windows.Forms.ComboBox();
            this.rTxtPrimeNumber = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerateRandomPrimeNumber
            // 
            this.btnGenerateRandomPrimeNumber.Location = new System.Drawing.Point(786, 12);
            this.btnGenerateRandomPrimeNumber.Name = "btnGenerateRandomPrimeNumber";
            this.btnGenerateRandomPrimeNumber.Size = new System.Drawing.Size(206, 23);
            this.btnGenerateRandomPrimeNumber.TabIndex = 0;
            this.btnGenerateRandomPrimeNumber.Text = "Generate Random Prime N";
            this.btnGenerateRandomPrimeNumber.UseVisualStyleBackColor = true;
            this.btnGenerateRandomPrimeNumber.Click += new System.EventHandler(this.btnGenerateRandomPrimeNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# decimals";
            // 
            // cbDecimals
            // 
            this.cbDecimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecimals.FormattingEnabled = true;
            this.cbDecimals.Location = new System.Drawing.Point(851, 39);
            this.cbDecimals.Name = "cbDecimals";
            this.cbDecimals.Size = new System.Drawing.Size(141, 21);
            this.cbDecimals.TabIndex = 2;
            // 
            // rTxtPrimeNumber
            // 
            this.rTxtPrimeNumber.Location = new System.Drawing.Point(789, 93);
            this.rTxtPrimeNumber.Name = "rTxtPrimeNumber";
            this.rTxtPrimeNumber.Size = new System.Drawing.Size(203, 427);
            this.rTxtPrimeNumber.TabIndex = 3;
            this.rTxtPrimeNumber.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed (decimal)";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(851, 67);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(141, 20);
            this.txtSeed.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1004, 576);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtPrimeNumber);
            this.Controls.Add(this.cbDecimals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateRandomPrimeNumber);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnGenerateRandomPrimeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDecimals;
        private System.Windows.Forms.RichTextBox rTxtPrimeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeed;
    }
}

