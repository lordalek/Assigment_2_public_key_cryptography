using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assigment2.Models;

namespace Assigment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (this.txtInput.Text.Length <= 0)
            {
                errorProvider1.SetError(this.txtInput, "Blank input not allowed");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}