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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rTxtEncrpyted = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTxtVD = new System.Windows.Forms.RichTextBox();
            this.rTxtN = new System.Windows.Forms.RichTextBox();
            this.rTxtPhi = new System.Windows.Forms.RichTextBox();
            this.rTxtVE = new System.Windows.Forms.RichTextBox();
            this.btnInsertCT = new System.Windows.Forms.Button();
            this.btnInsertPT = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnXmlPath = new System.Windows.Forms.Button();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrime1 = new System.Windows.Forms.TextBox();
            this.txtPrime2 = new System.Windows.Forms.TextBox();
            this.rTxtDecrypted = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCopyEncrpytedText = new System.Windows.Forms.Button();
            this.btnCopyDecryptedText = new System.Windows.Forms.Button();
            this.lbErrors = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.cboCryptoType = new System.Windows.Forms.ComboBox();
            this.cboSeed = new System.Windows.Forms.ComboBox();
            this.grpBox64 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt64Prim2 = new System.Windows.Forms.TextBox();
            this.txt64Prim1 = new System.Windows.Forms.TextBox();
            this.txtPrK = new System.Windows.Forms.TextBox();
            this.txtPK = new System.Windows.Forms.TextBox();
            this.txtPrimeProduct = new System.Windows.Forms.TextBox();
            this.txtTeution = new System.Windows.Forms.TextBox();
            this.btnSave64 = new System.Windows.Forms.Button();
            this.btnLoad64 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btn64Path = new System.Windows.Forms.Button();
            this.btnCalc64 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBox64.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateRandomPrimeNumber
            // 
            this.btnGenerateRandomPrimeNumber.Location = new System.Drawing.Point(1055, 13);
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
            this.label2.Location = new System.Drawing.Point(1055, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# decimals";
            // 
            // cbDecimals
            // 
            this.cbDecimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecimals.FormattingEnabled = true;
            this.cbDecimals.Location = new System.Drawing.Point(1120, 40);
            this.cbDecimals.Name = "cbDecimals";
            this.cbDecimals.Size = new System.Drawing.Size(141, 21);
            this.cbDecimals.TabIndex = 2;
            // 
            // rTxtPrimeNumber
            // 
            this.rTxtPrimeNumber.Location = new System.Drawing.Point(1058, 119);
            this.rTxtPrimeNumber.Name = "rTxtPrimeNumber";
            this.rTxtPrimeNumber.Size = new System.Drawing.Size(203, 402);
            this.rTxtPrimeNumber.TabIndex = 3;
            this.rTxtPrimeNumber.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1058, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed";
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
            // rTxtEncrpyted
            // 
            this.rTxtEncrpyted.Location = new System.Drawing.Point(13, 100);
            this.rTxtEncrpyted.Name = "rTxtEncrpyted";
            this.rTxtEncrpyted.Size = new System.Drawing.Size(527, 195);
            this.rTxtEncrpyted.TabIndex = 7;
            this.rTxtEncrpyted.Text = "";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rTxtVD);
            this.groupBox2.Controls.Add(this.rTxtN);
            this.groupBox2.Controls.Add(this.rTxtPhi);
            this.groupBox2.Controls.Add(this.rTxtVE);
            this.groupBox2.Controls.Add(this.btnInsertCT);
            this.groupBox2.Controls.Add(this.btnInsertPT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCipherText);
            this.groupBox2.Controls.Add(this.txtPlaintext);
            this.groupBox2.Controls.Add(this.btnXmlPath);
            this.groupBox2.Controls.Add(this.txtXMLPath);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnSaveData);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrime1);
            this.groupBox2.Controls.Add(this.txtPrime2);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Location = new System.Drawing.Point(563, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 508);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Variables for Really big numbers";
            // 
            // rTxtVD
            // 
            this.rTxtVD.Enabled = false;
            this.rTxtVD.Location = new System.Drawing.Point(128, 114);
            this.rTxtVD.Name = "rTxtVD";
            this.rTxtVD.Size = new System.Drawing.Size(100, 20);
            this.rTxtVD.TabIndex = 12;
            this.rTxtVD.Text = "";
            // 
            // rTxtN
            // 
            this.rTxtN.Enabled = false;
            this.rTxtN.Location = new System.Drawing.Point(128, 164);
            this.rTxtN.Name = "rTxtN";
            this.rTxtN.Size = new System.Drawing.Size(100, 20);
            this.rTxtN.TabIndex = 12;
            this.rTxtN.Text = "";
            // 
            // rTxtPhi
            // 
            this.rTxtPhi.Enabled = false;
            this.rTxtPhi.Location = new System.Drawing.Point(128, 139);
            this.rTxtPhi.Name = "rTxtPhi";
            this.rTxtPhi.Size = new System.Drawing.Size(100, 20);
            this.rTxtPhi.TabIndex = 12;
            this.rTxtPhi.Text = "";
            // 
            // rTxtVE
            // 
            this.rTxtVE.Enabled = false;
            this.rTxtVE.Location = new System.Drawing.Point(128, 88);
            this.rTxtVE.Name = "rTxtVE";
            this.rTxtVE.Size = new System.Drawing.Size(100, 20);
            this.rTxtVE.TabIndex = 12;
            this.rTxtVE.Text = "";
            // 
            // btnInsertCT
            // 
            this.btnInsertCT.Location = new System.Drawing.Point(100, 354);
            this.btnInsertCT.Name = "btnInsertCT";
            this.btnInsertCT.Size = new System.Drawing.Size(124, 23);
            this.btnInsertCT.TabIndex = 11;
            this.btnInsertCT.Text = "Insert ciphertext";
            this.btnInsertCT.UseVisualStyleBackColor = true;
            this.btnInsertCT.Click += new System.EventHandler(this.btnInsertCT_Click);
            // 
            // btnInsertPT
            // 
            this.btnInsertPT.Location = new System.Drawing.Point(100, 289);
            this.btnInsertPT.Name = "btnInsertPT";
            this.btnInsertPT.Size = new System.Drawing.Size(125, 23);
            this.btnInsertPT.TabIndex = 10;
            this.btnInsertPT.Text = "Insert plaintext";
            this.btnInsertPT.UseVisualStyleBackColor = true;
            this.btnInsertPT.Click += new System.EventHandler(this.btnInsertPT_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ciphertext";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Plaintext";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(9, 328);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(216, 20);
            this.txtCipherText.TabIndex = 8;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(9, 263);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(216, 20);
            this.txtPlaintext.TabIndex = 7;
            // 
            // btnXmlPath
            // 
            this.btnXmlPath.Location = new System.Drawing.Point(198, 439);
            this.btnXmlPath.Name = "btnXmlPath";
            this.btnXmlPath.Size = new System.Drawing.Size(30, 23);
            this.btnXmlPath.TabIndex = 6;
            this.btnXmlPath.Text = "...";
            this.btnXmlPath.UseVisualStyleBackColor = true;
            this.btnXmlPath.Click += new System.EventHandler(this.btnXmlPath_Click);
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(18, 439);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(174, 20);
            this.txtXMLPath.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(153, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(69, 479);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(150, 479);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "N (prime #1 * prime #2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Variable D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Variable E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "*Prime #2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "*Prime #1";
            // 
            // txtPrime1
            // 
            this.txtPrime1.Location = new System.Drawing.Point(128, 35);
            this.txtPrime1.Name = "txtPrime1";
            this.txtPrime1.Size = new System.Drawing.Size(100, 20);
            this.txtPrime1.TabIndex = 0;
            // 
            // txtPrime2
            // 
            this.txtPrime2.Location = new System.Drawing.Point(128, 61);
            this.txtPrime2.Name = "txtPrime2";
            this.txtPrime2.Size = new System.Drawing.Size(100, 20);
            this.txtPrime2.TabIndex = 0;
            // 
            // rTxtDecrypted
            // 
            this.rTxtDecrypted.Location = new System.Drawing.Point(12, 350);
            this.rTxtDecrypted.Name = "rTxtDecrypted";
            this.rTxtDecrypted.Size = new System.Drawing.Size(528, 164);
            this.rTxtDecrypted.TabIndex = 10;
            this.rTxtDecrypted.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Encrpyted text";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Decrypted text";
            // 
            // btnCopyEncrpytedText
            // 
            this.btnCopyEncrpytedText.Location = new System.Drawing.Point(349, 301);
            this.btnCopyEncrpytedText.Name = "btnCopyEncrpytedText";
            this.btnCopyEncrpytedText.Size = new System.Drawing.Size(191, 23);
            this.btnCopyEncrpytedText.TabIndex = 12;
            this.btnCopyEncrpytedText.Text = "Copy encrpyted text to input field";
            this.btnCopyEncrpytedText.UseVisualStyleBackColor = true;
            this.btnCopyEncrpytedText.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopyDecryptedText
            // 
            this.btnCopyDecryptedText.Location = new System.Drawing.Point(349, 520);
            this.btnCopyDecryptedText.Name = "btnCopyDecryptedText";
            this.btnCopyDecryptedText.Size = new System.Drawing.Size(191, 23);
            this.btnCopyDecryptedText.TabIndex = 12;
            this.btnCopyDecryptedText.Text = "Copy dencrpyted text to input field";
            this.btnCopyDecryptedText.UseVisualStyleBackColor = true;
            this.btnCopyDecryptedText.Click += new System.EventHandler(this.btnCopyDecryptedText_Click);
            // 
            // lbErrors
            // 
            this.lbErrors.AutoSize = true;
            this.lbErrors.ForeColor = System.Drawing.Color.Red;
            this.lbErrors.Location = new System.Drawing.Point(13, 13);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(0, 13);
            this.lbErrors.TabIndex = 13;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(311, 42);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 13);
            this.lbProgress.TabIndex = 14;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(94, 32);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrpyt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // cboCryptoType
            // 
            this.cboCryptoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCryptoType.FormattingEnabled = true;
            this.cboCryptoType.Location = new System.Drawing.Point(175, 34);
            this.cboCryptoType.Name = "cboCryptoType";
            this.cboCryptoType.Size = new System.Drawing.Size(365, 21);
            this.cboCryptoType.TabIndex = 16;
            // 
            // cboSeed
            // 
            this.cboSeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeed.FormattingEnabled = true;
            this.cboSeed.Location = new System.Drawing.Point(1120, 66);
            this.cboSeed.Name = "cboSeed";
            this.cboSeed.Size = new System.Drawing.Size(141, 21);
            this.cboSeed.TabIndex = 17;
            // 
            // grpBox64
            // 
            this.grpBox64.Controls.Add(this.txtTeution);
            this.grpBox64.Controls.Add(this.txtPK);
            this.grpBox64.Controls.Add(this.txtPrimeProduct);
            this.grpBox64.Controls.Add(this.txtPrK);
            this.grpBox64.Controls.Add(this.txt64Prim1);
            this.grpBox64.Controls.Add(this.txt64Prim2);
            this.grpBox64.Controls.Add(this.label3);
            this.grpBox64.Controls.Add(this.btn64Path);
            this.grpBox64.Controls.Add(this.textBox9);
            this.grpBox64.Controls.Add(this.btnLoad64);
            this.grpBox64.Controls.Add(this.label4);
            this.grpBox64.Controls.Add(this.btnSave64);
            this.grpBox64.Controls.Add(this.label15);
            this.grpBox64.Controls.Add(this.label16);
            this.grpBox64.Controls.Add(this.label17);
            this.grpBox64.Controls.Add(this.label18);
            this.grpBox64.Controls.Add(this.btnCalc64);
            this.grpBox64.Location = new System.Drawing.Point(813, 21);
            this.grpBox64.Name = "grpBox64";
            this.grpBox64.Size = new System.Drawing.Size(200, 500);
            this.grpBox64.TabIndex = 18;
            this.grpBox64.TabStop = false;
            this.grpBox64.Text = "Set Variables for 64 Bit";
            this.grpBox64.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prime Product";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teution";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Private Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Public Key";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "*Prime #2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "*Prime #1";
            // 
            // txt64Prim2
            // 
            this.txt64Prim2.Location = new System.Drawing.Point(94, 52);
            this.txt64Prim2.Name = "txt64Prim2";
            this.txt64Prim2.Size = new System.Drawing.Size(100, 20);
            this.txt64Prim2.TabIndex = 8;
            // 
            // txt64Prim1
            // 
            this.txt64Prim1.Location = new System.Drawing.Point(94, 26);
            this.txt64Prim1.Name = "txt64Prim1";
            this.txt64Prim1.Size = new System.Drawing.Size(100, 20);
            this.txt64Prim1.TabIndex = 8;
            // 
            // txtPrK
            // 
            this.txtPrK.Enabled = false;
            this.txtPrK.Location = new System.Drawing.Point(94, 106);
            this.txtPrK.Name = "txtPrK";
            this.txtPrK.Size = new System.Drawing.Size(100, 20);
            this.txtPrK.TabIndex = 8;
            // 
            // txtPK
            // 
            this.txtPK.Enabled = false;
            this.txtPK.Location = new System.Drawing.Point(94, 80);
            this.txtPK.Name = "txtPK";
            this.txtPK.Size = new System.Drawing.Size(100, 20);
            this.txtPK.TabIndex = 8;
            // 
            // txtPrimeProduct
            // 
            this.txtPrimeProduct.Enabled = false;
            this.txtPrimeProduct.Location = new System.Drawing.Point(94, 156);
            this.txtPrimeProduct.Name = "txtPrimeProduct";
            this.txtPrimeProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeProduct.TabIndex = 8;
            // 
            // txtTeution
            // 
            this.txtTeution.Enabled = false;
            this.txtTeution.Location = new System.Drawing.Point(94, 130);
            this.txtTeution.Name = "txtTeution";
            this.txtTeution.Size = new System.Drawing.Size(100, 20);
            this.txtTeution.TabIndex = 8;
            // 
            // btnSave64
            // 
            this.btnSave64.Location = new System.Drawing.Point(133, 239);
            this.btnSave64.Name = "btnSave64";
            this.btnSave64.Size = new System.Drawing.Size(57, 23);
            this.btnSave64.TabIndex = 2;
            this.btnSave64.Text = "Save";
            this.btnSave64.UseVisualStyleBackColor = true;
            this.btnSave64.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoad64
            // 
            this.btnLoad64.Location = new System.Drawing.Point(70, 239);
            this.btnLoad64.Name = "btnLoad64";
            this.btnLoad64.Size = new System.Drawing.Size(57, 23);
            this.btnLoad64.TabIndex = 3;
            this.btnLoad64.Text = "Load";
            this.btnLoad64.UseVisualStyleBackColor = true;
            this.btnLoad64.Click += new System.EventHandler(this.btnLoad64_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(5, 210);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(156, 20);
            this.textBox9.TabIndex = 5;
            this.textBox9.Click += new System.EventHandler(this.textBox9_Click);
            // 
            // btn64Path
            // 
            this.btn64Path.Location = new System.Drawing.Point(162, 210);
            this.btn64Path.Name = "btn64Path";
            this.btn64Path.Size = new System.Drawing.Size(27, 23);
            this.btn64Path.TabIndex = 6;
            this.btn64Path.Text = "...";
            this.btn64Path.UseVisualStyleBackColor = true;
            // 
            // btnCalc64
            // 
            this.btnCalc64.Location = new System.Drawing.Point(118, 182);
            this.btnCalc64.Name = "btnCalc64";
            this.btnCalc64.Size = new System.Drawing.Size(75, 23);
            this.btnCalc64.TabIndex = 4;
            this.btnCalc64.Text = "Calculate";
            this.btnCalc64.UseVisualStyleBackColor = true;
            this.btnCalc64.Click += new System.EventHandler(this.btnCalc64_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1273, 658);
            this.Controls.Add(this.grpBox64);
            this.Controls.Add(this.cboSeed);
            this.Controls.Add(this.cboCryptoType);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.btnCopyDecryptedText);
            this.Controls.Add(this.btnCopyEncrpytedText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rTxtDecrypted);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rTxtEncrpyted);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtPrimeNumber);
            this.Controls.Add(this.cbDecimals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateRandomPrimeNumber);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBox64.ResumeLayout(false);
            this.grpBox64.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnGenerateRandomPrimeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDecimals;
        private System.Windows.Forms.RichTextBox rTxtPrimeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox rTxtEncrpyted;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrime1;
        private System.Windows.Forms.TextBox txtPrime2;
        private System.Windows.Forms.Button btnXmlPath;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnInsertCT;
        private System.Windows.Forms.Button btnInsertPT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rTxtDecrypted;
        private System.Windows.Forms.Button btnCopyDecryptedText;
        private System.Windows.Forms.Button btnCopyEncrpytedText;
        private System.Windows.Forms.Label lbErrors;
        private System.Windows.Forms.RichTextBox rTxtVD;
        private System.Windows.Forms.RichTextBox rTxtN;
        private System.Windows.Forms.RichTextBox rTxtPhi;
        private System.Windows.Forms.RichTextBox rTxtVE;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox cboCryptoType;
        private System.Windows.Forms.ComboBox cboSeed;
        private System.Windows.Forms.GroupBox grpBox64;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTeution;
        private System.Windows.Forms.TextBox txtPK;
        private System.Windows.Forms.TextBox txtPrimeProduct;
        private System.Windows.Forms.TextBox txtPrK;
        private System.Windows.Forms.TextBox txt64Prim1;
        private System.Windows.Forms.TextBox txt64Prim2;
        private System.Windows.Forms.Button btn64Path;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnLoad64;
        private System.Windows.Forms.Button btnSave64;
        private System.Windows.Forms.Button btnCalc64;
    }
}

