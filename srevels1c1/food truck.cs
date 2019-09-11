using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels1c1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHDPrice.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            txtHBPrice.Text = (
                5.0m * Convert.ToDecimal(txtHamburger.Text)
                ).ToString("0.00");

            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHBPrice.Text) 
                + Convert.ToDecimal(txtHDPrice.Text)
                ).ToString("0.00");

            txtTax.Text = (
                0.0688m * Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString ("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburger.Text = "0";
            txtHBPrice.Text = "";
            txtHDPrice.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void TxtHotDogs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtHamburger_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
