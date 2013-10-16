using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
            txtXMLPath.Text =
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ??
                string.Empty;
            rsa = new RSA();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (long i = 1; i <= 100; i++)
            {
                this.cbDecimals.Items.Add(i);
            }
        }

        private void btnGenerateRandomPrimeNumber_Click(object sender, EventArgs e)
        {
            try
            {
                this.rTxtPrimeNumber.Text = string.Empty;
                this.rTxtPrimeNumber.Tag = null;
                if (this.cbDecimals.SelectedItem == null)
                    return;
                var seed = -1L;
                long.TryParse(this.txtSeed.Text, out seed);
                if (this.txtSeed.Text.Length <= 0 || seed <= 0)
                    return;
                this.Cursor = Cursors.WaitCursor;
                var psRandomNumberino = new ReallyBigNumber("1").GetRandomPrime(seed,
                    (long) this.cbDecimals.SelectedItem);
                this.rTxtPrimeNumber.Text = psRandomNumberino.ToString();
                this.rTxtPrimeNumber.Tag = psRandomNumberino;
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
                if (!hasErrors)
                {
                    errorProvider1.Clear();
                    this.lbErrors.Text = "";
                    var encryptedText = rsa.Encrpypt(rsa.N, this.txtInput.Text, rsa.VariableD);
                    this.rTxtEncrpyted.Tag = encryptedText;
                    this.rTxtEncrpyted.Text = encryptedText.ToString();
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
                    N = rsa.N ?? new ReallyBigNumber("0"),
                    Phi = rsa.Phi ?? new ReallyBigNumber("0"),
                    Prime2 = rsa.Prime1 ?? new ReallyBigNumber("0"),
                    Prime1 = rsa.Prime2 ?? new ReallyBigNumber("0"),
                    VariableE = rsa.VariableE ?? new ReallyBigNumber("0"),
                    VariableD = rsa.VariableD ?? new ReallyBigNumber("0")
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

        }
    }
}