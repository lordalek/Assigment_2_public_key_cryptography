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
            this.components = new System.ComponentModel.Container();
            this.btnGenerateRandomPrimeNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDecimals = new System.Windows.Forms.ComboBox();
            this.rTxtPrimeNumber = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rProcessedText = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(13, 32);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // rProcessedText
            // 
            this.rProcessedText.Location = new System.Drawing.Point(13, 93);
            this.rProcessedText.Name = "rProcessedText";
            this.rProcessedText.Size = new System.Drawing.Size(527, 427);
            this.rProcessedText.TabIndex = 7;
            this.rProcessedText.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 61);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(528, 20);
            this.txtInput.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(546, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 508);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Variables";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1004, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rProcessedText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtPrimeNumber);
            this.Controls.Add(this.cbDecimals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateRandomPrimeNumber);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox rProcessedText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

