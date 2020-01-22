using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer
{
    public partial class calculator : Form
    {
        int calflg = 0;
        double sum, num1, num2;
        bool DP = false;

        public calculator()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "1";
            }
            else
            {
                CalculatorView.Text += 1;
            }
            
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "2";
            }
            else
            {
                CalculatorView.Text += 2;
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "3";
            }
            else
            {
                CalculatorView.Text += 3;
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "4";
            }
            else
            {
                CalculatorView.Text += 4;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "5";
            }
            else
            {
                CalculatorView.Text += 5;
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "6";
            }
            else
            {
                CalculatorView.Text += 6;
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "7";
            }
            else
            {
                CalculatorView.Text += 7;
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "8";
            }
            else
            {
                CalculatorView.Text += 8;
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {
                CalculatorView.Text = "9";
            }
            else
            {
                CalculatorView.Text += 9;
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {

            }
            else
            {
                CalculatorView.Text += 0;
            }
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            CalculatorView.Text = "0";
        }

        private void BCE_Click(object sender, EventArgs e)
        {
            CalculatorView.Text = "0";
        }

        private void BC_Click(object sender, EventArgs e)
        {
            CalculatorView.Text = "0";
            PreviousValue.Text = "0";
            DP = false;
        }

        private void Bsub_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {

            }
            else
            {
                PreviousValue.Text = CalculatorView.Text;
                CalculatorView.Text = "0";
                calflg = 2;
            }
        }

        private void Bmul_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {

            }
            else
            {
                PreviousValue.Text = CalculatorView.Text;
                CalculatorView.Text = "0";
                calflg = 3;
            }
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {

            }
            else
            {
                PreviousValue.Text = CalculatorView.Text;
                CalculatorView.Text = "0";
                calflg = 4;
            }
        }

        private void Brem_Click(object sender, EventArgs e)
        {
            if (CalculatorView.Text == "0")
            {

            }
            else
            {
                PreviousValue.Text = CalculatorView.Text;
                CalculatorView.Text = "0";
                calflg = 5;
            }
        }

        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            if(DP == false)
            {
                CalculatorView.Text += ".";
                DP = true;
            }
            else
            {

            }
            
        }

        private void Badd_Click(object sender, EventArgs e)
        {
            if(CalculatorView.Text == "0")
            {

            }
            else
            {
                PreviousValue.Text = CalculatorView.Text;
                CalculatorView.Text = "0";
                calflg = 1;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if(calflg == 1)
            {
                num1 = double.Parse(PreviousValue.Text);
                num2 = double.Parse(CalculatorView.Text);
                sum = num1 + num2;
                PreviousValue.Text = "0";
                CalculatorView.Text = Convert.ToString(sum);
                calflg = 0;
            }
            else if(calflg == 2)
            {
                num1 = double.Parse(PreviousValue.Text);
                num2 = double.Parse(CalculatorView.Text);
                sum = num1 - num2;
                PreviousValue.Text = "0";
                CalculatorView.Text = Convert.ToString(sum);
                calflg = 0;
            }
            else if(calflg == 3)
            {
                num1 = double.Parse(PreviousValue.Text);
                num2 = double.Parse(CalculatorView.Text);
                sum = num1 * num2;
                PreviousValue.Text = "0";
                CalculatorView.Text = Convert.ToString(sum);
                calflg = 0;
            }
            else if(calflg == 4)
            {
                num1 = double.Parse(PreviousValue.Text);
                num2 = double.Parse(CalculatorView.Text);
                sum = num1 / num2;
                PreviousValue.Text = "0";
                CalculatorView.Text = Convert.ToString(sum);
                calflg = 0;
            }
            else if(calflg == 5)
            {
                num1 = double.Parse(PreviousValue.Text);
                num2 = double.Parse(CalculatorView.Text);
                sum = num1 % num2;
                PreviousValue.Text = "0";
                CalculatorView.Text = Convert.ToString(sum);
                calflg = 0;
            }

            DP = false;

        }
    }
}
