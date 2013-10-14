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
            for (int i = 10; i <= 309; i++)
            {
                this.cbDecimals.Items.Add(i);
            }
        }

        private void btnGenerateRandomPrimeNumber_Click(object sender, EventArgs e)
        {
            if (this.cbDecimals.SelectedItem == null)
                return;
            var seed = -1L;
            long.TryParse(this.txtSeed.Text, out seed);
            if (this.txtSeed.Text.Length <= 0 || seed <= 0)
                return;
            var psRandomNumberino = new ReallyBigNumber("1").GetRandomNumber(seed,(int) this.cbDecimals.SelectedItem);
            this.rTxtPrimeNumber.Text = psRandomNumberino.ToString();
            this.rTxtPrimeNumber.Tag = psRandomNumberino;
        }
    }
}