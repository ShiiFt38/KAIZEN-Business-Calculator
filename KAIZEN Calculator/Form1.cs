using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAIZEN_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Top;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        public void loadSubForm(object Form)
        {
            
        }

        public void loadHome(object Form)

        {
            Application.Restart();
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
          
            loadform(new Financial_Perspective_Form());
            loadform(new Financial_Perspective_Form());
            loadform(new Financial_Perspective_Form());
            loadform(new Financial_Perspective_Form());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadHome(new Form1());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMarketingSales_Click(object sender, EventArgs e)
        {
            loadform(new Marketing_and_Sales_Perspective());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadform(new frmCustomer());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            loadform(new Employee_form());
        }

        private void btnOperational_Click(object sender, EventArgs e)
        {
            loadform(new Operational_Form());
        }

        private void btnCorporate_Click(object sender, EventArgs e)
        {
            loadform(new Corporate_Social_Responsibility_Form());
        }

        double num1 = 0;
        double num2;
        string option;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != 0)
                {
                    num2 = double.Parse(txtDisplay.Text);
                    Buttons equalbutton = new Buttons();
                    equalbutton.option = option;
                    equalbutton.num1 = num1;
                    equalbutton.num2 = num2;
                    equalbutton.Equal();
                    num1 = equalbutton.result;
                    option = "+";
                    txtDisplay2.Clear();
                    txtDisplay.Clear();
                    txtDisplay2.Text = equalbutton.result + " + ";
                }
                else
                {
                    option = "+";
                    num1 = double.Parse(txtDisplay.Text);
                    txtDisplay2.Text = txtDisplay.Text;
                    txtDisplay2.Text += " + ";

                    txtDisplay.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != 0)
                {
                    num2 = double.Parse(txtDisplay.Text);
                    Buttons equalbutton = new Buttons();
                    equalbutton.option = option;
                    equalbutton.num1 = num1;
                    equalbutton.num2 = num2;
                    equalbutton.Equal();
                    num1 = equalbutton.result;
                    option = "-";
                    txtDisplay2.Clear();
                    txtDisplay.Clear();
                    txtDisplay2.Text = equalbutton.result + " - ";
                }
                else
                {
                    option = "-";
                    num1 = double.Parse(txtDisplay.Text);
                    txtDisplay2.Text = txtDisplay.Text;
                    txtDisplay2.Text += " - ";

                    txtDisplay.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {


                if (num1 != 0)
                {
                    num2 = double.Parse(txtDisplay.Text);
                    Buttons equalbutton = new Buttons();
                    equalbutton.option = option;
                    equalbutton.num1 = num1;
                    equalbutton.num2 = num2;
                    equalbutton.Equal();
                    num1 = equalbutton.result;
                    option = "*";
                    txtDisplay2.Clear();
                    txtDisplay.Clear();
                    txtDisplay2.Text = equalbutton.result + " x ";
                }
                else
                {
                    option = "*";
                    num1 = double.Parse(txtDisplay.Text);
                    txtDisplay2.Text = txtDisplay.Text;
                    txtDisplay2.Text += " x ";

                    txtDisplay.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)//÷
        {
            try
            {

                if (num1 != 0)
                {
                    num2 = double.Parse(txtDisplay.Text);
                    Buttons equalbutton = new Buttons();
                    equalbutton.option = option;
                    equalbutton.num1 = num1;
                    equalbutton.num2 = num2;
                    equalbutton.Equal();
                    num1 = equalbutton.result;
                    option = "/";
                    txtDisplay2.Clear();
                    txtDisplay.Clear();
                    txtDisplay2.Text = equalbutton.result + " ÷ ";
                }
                else
                {
                    option = "/";
                    num1 = double.Parse(txtDisplay.Text);
                    txtDisplay2.Text = txtDisplay.Text;
                    txtDisplay2.Text += " ÷ ";

                    txtDisplay.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bntEql_Click(object sender, EventArgs e)
        {
            try
            {
                Buttons equalbutton = new Buttons();
                equalbutton.option = option;
                equalbutton.num1 = num1;
                equalbutton.num2 = Convert.ToDouble(txtDisplay.Text);
                equalbutton.Equal();
                txtDisplay2.Text += equalbutton.num2 + " =";
                txtDisplay.Text = equalbutton.result.ToString();
                num1 = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay2.Clear();
            num1 = (0);
            num2 = (0);
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
