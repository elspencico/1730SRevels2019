using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels1d2
{
    public partial class fmCurrencyExchange : Form
    {
        public fmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmCurrencyExchange_Load(object sender, EventArgs e)
        {

        } 



        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAUAmount.Text = "0.00";
            txtAURate.Text = "0.717976";
            txtBTAmount.Text = "0.00";
            txtBTRate.Text = "0.0139831";
            txtCRAmount.Text = "0.00";
            txtCRRate.Text = "0.0017";
            txtEUAmount.Text = "0.00";
            txtEURate.Text = "1.11";
            txtAUAmount.Focus();
        }

        private void AustraliaTextChanged(object sender, EventArgs e)
        {
            txtAUUSA.Text = (
                Convert.ToDecimal(txtAUAmount.Text)
                * Convert.ToDecimal(txtAURate.Text)
                ).ToString("0.00");
        } 

        private void LblAmount_Click(object sender, EventArgs e)
        {

        }

        private void BhutanTextChanged(object sender, EventArgs e)
        {
            txtBTUSA.Text = (
                Convert.ToDecimal(txtBTAmount.Text)
                * Convert.ToDecimal(txtBTRate.Text)
                ).ToString("0.00");
        }

        private void CostaRicaTextChanged(object sender, EventArgs e)
        {
            txtCRUSA.Text = (
                Convert.ToDecimal(txtCRAmount.Text)
                * Convert.ToDecimal(txtCRRate.Text)
                ).ToString("0.00");
        }

        private void EUTextChanged(object sender, EventArgs e)
        {
            txtEUUSA.Text = (
                 Convert.ToDecimal(txtEUAmount.Text)
                 * Convert.ToDecimal(txtEURate.Text)
                 ).ToString("0.00");
        }

        private void USDTextChange(object sender, EventArgs e)
        {
            txtTotal.Text = (
                Convert.ToDecimal(txtAUUSA.Text)
                + Convert.ToDecimal(txtBTUSA.Text)
                + Convert.ToDecimal(txtCRUSA.Text)
                + Convert.ToDecimal(txtEUUSA.Text)
                ).ToString("0.00");
        }
    }
}
