using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAIZEN_Calculator
{
    public partial class Financial_Perspective_Form : Form
    {
        public Financial_Perspective_Form()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

        }

        private void txtSalesRevenue_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtSalesRevenue.Text = "";
            txtTotalCosts.Text = "";
            txtNetProfit.Text = "";
        }

        private void txtTotalCosts_Enter(object sender, EventArgs e)
        {

        }

        private void txtSalesRevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGross_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Financial_Calculations NetP = new Financial_Calculations();
                NetP.salesRevenue = Convert.ToDouble(txtSalesRevenue.Text);
                NetP.totalCosts = Convert.ToDouble(txtTotalCosts.Text);
                NetP.getNetProfit();
                txtNetProfit.Text = NetP.netProfit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
