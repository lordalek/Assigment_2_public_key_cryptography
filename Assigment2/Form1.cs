﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assigment2.Logic;
using Assigment2.Models;

namespace Assigment2
{
    public partial class Form1 : Form
    {
        public RSA rsa { get; set; }
        public RSA64Bit Rsa64 { get; set; }

        public Form1()
        {
            InitializeComponent();
            txtXMLPath.Text =
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ??
                string.Empty;
            rsa = new RSA();
            Rsa64 = new RSA64Bit();

            PopulateMetaData();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            this.cboCryptoType.Items.Add("64 bit");
            this.cboCryptoType.Items.Add("Unliminted bit, not working");
        }

        private void PopulateMetaData()
        {
            btnLoad_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (long i = 1; i <= 100; i++)
            {
                this.cbDecimals.Items.Add(i);
            }
            for (int i = 1; i < 100; i++)
            {
                this.cboSeed.Items.Add(i);
            }
        }

        private void btnGenerateRandomPrimeNumber_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var hasErrors = false;
                if (this.cboCryptoType.SelectedItem == null)
                {
                    errorProvider1.SetError(this.cboCryptoType, "Please pick a type");
                    this.lbErrors.Text = "Please pick a type";
                    hasErrors = true;
                }
                if (this.cbDecimals.SelectedItem == null)
                {
                    errorProvider1.SetError(this.cbDecimals, "Please pick a value");
                    this.lbErrors.Text = "Please pick a value";
                    hasErrors = true;
                }
                if (this.cboSeed.Text.Length <= 0)
                {
                    errorProvider1.SetError(this.cboSeed, "Please pick a seed");
                    this.lbErrors.Text = "Please pick a seed";
                    hasErrors = true;
                }
                if (!hasErrors)
                {
                    errorProvider1.Clear();
                    this.lbErrors.Text = "";

                    this.rTxtPrimeNumber.Text = string.Empty;
                    this.rTxtPrimeNumber.Tag = null;
                    if (this.cboCryptoType.SelectedItem.ToString()
                        .Equals("64 bit", StringComparison.CurrentCultureIgnoreCase))
                    {
                        var psRandomNumberino = RSA64Bit.GetRandomPrimeNumber(int.Parse(this.cboSeed.Text),
                            int.Parse(this.cbDecimals.SelectedItem.ToString()));
                        this.rTxtPrimeNumber.Text = psRandomNumberino.ToString();
                        this.rTxtPrimeNumber.Tag = psRandomNumberino;
                    }
                    else
                    {
                        if (this.cbDecimals.SelectedItem == null)
                            return;
                        var seed = -1L;
                        long.TryParse(this.cboSeed.Text, out seed);
                        if (this.cboSeed.Text.Length <= 0 || seed <= 0)
                            return;
                        var psRandomNumberino = new ReallyBigNumber("1").GetRandomPrime(seed,
                            (long) this.cbDecimals.SelectedItem);
                        this.rTxtPrimeNumber.Text = psRandomNumberino.ToString();
                        this.rTxtPrimeNumber.Tag = psRandomNumberino;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var hasErrors = false;
                if (this.txtInput.Text.Length <= 0)
                {
                    errorProvider1.SetError(this.txtInput, "Blank input not allowed");
                    this.lbErrors.Text = "Blank input not allowed";
                    hasErrors = true;
                }
                if (rsa.N == null || rsa.Phi == null || rsa.Prime1 == null || rsa.Prime1 == null ||
                    rsa.VariableD == null || rsa.VariableE == null)
                {
                    errorProvider1.SetError(this.btnCalculate, "Parametres are not initialized");
                    this.lbErrors.Text = "Parametres are not initialized";
                    hasErrors = true;
                }
                if (this.cboCryptoType.SelectedItem == null)
                {
                    errorProvider1.SetError(this.cboCryptoType, "Please pick a type");
                    this.lbErrors.Text = "Please pick a type";
                    hasErrors = true;
                }
                if (!hasErrors)
                {
                    errorProvider1.Clear();
                    this.lbErrors.Text = "";
                    var encryptedText = string.Empty;
                    encryptedText = string.Equals(this.cboCryptoType.SelectedItem.ToString(), "64 bit",
                        StringComparison.CurrentCultureIgnoreCase)
                        ? Rsa64.Encrypt(this.txtInput.Text, Rsa64.PublicKeyFactor, this.Rsa64.PrimeProductRoof)
                        : rsa.EncrpytSingleLetterBlock(rsa.N, this.txtInput.Text, rsa.VariableE);
                    this.rTxtEncrpyted.Tag = encryptedText;
                    this.rTxtEncrpyted.Text = encryptedText.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to encrypt. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnXmlPath_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new FolderBrowserDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                    txtXMLPath.Text = fileDialog.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save data to field.. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtXMLPath.Text.Length <= 0)
                    return;

                var info = new RsaInfo()
                {
                    N = rsa.N.ToString(),
                    Phi = rsa.Phi.ToString(),
                    Prime2 = txtPrime1.Text,
                    Prime1 = txtPrime2.Text,
                    VariableE = rsa.VariableE.ToString(),
                    VariableD = rsa.VariableD.ToString(),
                    CipherText = txtCipherText.Text ?? string.Empty,
                    PlainText = txtPlaintext.Text ?? string.Empty
                };
                Helper.SaveCryptionInfo(info, txtXMLPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save data to field.. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                this.lbErrors.Text = "";
                this.Cursor = Cursors.WaitCursor;
                var hasErrors = false;
                if (this.txtPrime1.Text.Length <= 0 || this.txtPrime2.Text.Length <= 0)
                {
                    errorProvider1.SetError(this.txtPrime1, "Primes are not initialized");
                    errorProvider1.SetError(this.txtPrime2, "Primes are not initialized");
                    this.lbErrors.Text += "Primes are not initialized. ";
                    hasErrors = true;
                }
                if (this.txtPrime1.Text.Length > 0)
                {
                    var temp = new ReallyBigNumber(txtPrime1.Text);
                    if (!temp.IsPrime(new ReallyBigNumber(txtPrime1.Text)))
                    {
                        errorProvider1.SetError(this.txtPrime2, "Prime #1 is not a prime");
                        this.lbErrors.Text += "Prime #1 is not a prime. ";
                        hasErrors = true;
                    }
                }
                if (this.txtPrime2.Text.Length > 0)
                {
                    var temp = new ReallyBigNumber(txtPrime2.Text);
                    if (!temp.IsPrime(new ReallyBigNumber(txtPrime2.Text)))
                    {
                        errorProvider1.SetError(this.txtPrime2, "Prime #2 is not a prime");
                        this.lbErrors.Text += "Prime #2 is not a prime. ";
                        hasErrors = true;
                    }
                }
                if (this.txtPrime2.Text.Length > 0 && this.txtPrime1.Text.Length > 0 && !hasErrors)
                {
                    if (new ReallyBigNumber(txtPrime2.Text).Equals(new ReallyBigNumber(txtPrime1.Text)))
                    {
                        errorProvider1.SetError(this.btnCalculate, "Primes may not be equal");
                        this.lbErrors.Text += "Primes may not be equal. ";
                        hasErrors = true;
                    }
                }
                if (!hasErrors)
                {
                    errorProvider1.Clear();
                    this.lbErrors.Text = "";
                    rsa.Prime1 = new ReallyBigNumber(txtPrime1.Text);
                    rsa.Prime2 = new ReallyBigNumber(txtPrime2.Text);

                    rsa.N = rsa.CalculateN(rsa.Prime1, rsa.Prime2);
                    rsa.Phi = rsa.CaluculatePhi(rsa.Prime1, rsa.Prime2);
                    rsa.VariableE = rsa.SelectERelativeToPhiAndSmallerThanPhi(rsa.Phi, rsa.N);
                    rsa.VariableD = rsa.DetermineDAs1AndSMallerThanPhi(rsa.Phi, rsa.VariableE);

                    rTxtN.Text = rsa.N.ToString();
                    rTxtPhi.Text = rsa.Phi.ToString();
                    rTxtVD.Text = rsa.VariableD.ToString();
                    rTxtVE.Text = rsa.VariableE.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to calculate. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var info =
                Helper.GetCryptionInfo(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            rsa = new RSA()
            {
                N = new ReallyBigNumber(info.N),
                Phi = new ReallyBigNumber(info.Phi),
                VariableE = new ReallyBigNumber(info.VariableE),
                VariableD = new ReallyBigNumber(info.VariableD),
                Prime2 = new ReallyBigNumber(info.Prime2),
                Prime1 = new ReallyBigNumber(info.Prime1)
            };
            this.rTxtVD.Text = info.VariableD;
            this.rTxtVE.Text = info.VariableE;
            this.rTxtPhi.Text = info.Phi;
            this.rTxtN.Text = info.N;
            this.txtPrime1.Text = info.Prime1;
            this.txtPrime2.Text = info.Prime2;
            this.rTxtDecrypted.Text = info.PlainText;
            this.txtPlaintext.Text = info.PlainText;
            this.txtCipherText.Text = info.PlainText;
            this.rTxtEncrpyted.Text = info.CipherText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rTxtEncrpyted.Tag == null)
                    throw new NullReferenceException("rTxtEncrypted.Tag");
                this.txtInput.Text = (string) rTxtEncrpyted.Tag;
                this.txtCipherText.Text = (string) rTxtEncrpyted.Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to copy. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCopyDecryptedText_Click(object sender, EventArgs e)
        {
            try
            {
                if (rTxtDecrypted.Tag == null)
                    throw new NullReferenceException("rTxtDecrypted.Tag");
                this.txtInput.Text = (string) rTxtDecrypted.Tag;
                this.txtPlaintext.Text = (string) rTxtEncrpyted.Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to copy. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnInsertPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPlaintext.Text))
                return;
            this.txtInput.Text = this.txtPlaintext.Text;
        }

        private void btnInsertCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCipherText.Text))
                return;
            this.txtInput.Text = this.txtCipherText.Text;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var hasErrors = false;
                if (this.txtInput.Text.Length <= 0)
                {
                    errorProvider1.SetError(this.txtInput, "Blank input not allowed");
                    this.lbErrors.Text = "Blank input not allowed";
                    hasErrors = true;
                }
                if (rsa.N == null || rsa.Phi == null || rsa.Prime1 == null || rsa.Prime1 == null ||
                    rsa.VariableD == null || rsa.VariableE == null)
                {
                    errorProvider1.SetError(this.btnCalculate, "Parametres are not initialized");
                    this.lbErrors.Text = "Parametres are not initialized";
                    hasErrors = true;
                }
                if (this.cboCryptoType.SelectedItem == null)
                {
                    errorProvider1.SetError(this.cboCryptoType, "Please pick a type");
                    this.lbErrors.Text = "Please pick a type";
                    hasErrors = true;
                }
                if (!hasErrors)
                {
                    errorProvider1.Clear();
                    this.lbErrors.Text = "";
                    var deCryptedText = string.Empty;
                    deCryptedText = string.Equals(this.cboCryptoType.SelectedItem.ToString(), "64 bit",
                        StringComparison.CurrentCultureIgnoreCase)
                        ? Rsa64.Decrypt(this.txtInput.Text, Rsa64.PrivateKeyFactor, Rsa64.PrimeProductRoof)
                        : rsa.DecryptSingleLetterBlock(rsa.N, this.txtInput.Text, rsa.VariableD);
                    this.rTxtDecrypted.Tag = deCryptedText;
                    this.rTxtDecrypted.Text = deCryptedText.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to calculate. Error: " + Environment.NewLine + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}