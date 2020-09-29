using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_McEwen
{
    public partial class Form1 : Form
    {
        double input;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSumSeries.Text   = "";
            txtProductSum.Text  = "";
            txtDivisionSum.Text = "";
            txtSumLimit.Text    = "";
            txtSumOdd.Text      = "";
            txtProductOdd.Text  = "";
            txtInput.Text       = "";
            txtInput.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            MethodSumSer  ();
            MethodProdSum ();
            MethodDivSum  ();
            MethodSumlim  ();
            MethodSumOdd  ();
            MethodProdOdd ();
        }

        private void MethodSumSer()
        {
            input = double.Parse(txtInput.Text);
            double outputSumSer = 0;
            double count = 1;

             while (count <= input)
             {
                outputSumSer += count;
                count++;
             }
            txtSumSeries.Text = outputSumSer.ToString();
        }

        private void MethodProdSum()
        {
            input = double.Parse(txtInput.Text);
            double outputProdSum = 1;
            double count = 1;

            while (count <= input)
            {
                outputProdSum *= count;
                count++;
            }
            txtProductSum.Text = outputProdSum.ToString();
        }

        private void MethodDivSum()
        {
            input = double.Parse(txtInput.Text);
            double outputDivSum = 1;
            double count = 1;

            while (count <= input)
            {
                outputDivSum /= count;
                count++;
            }
            txtDivisionSum.Text = outputDivSum.ToString("N8");
        }

        private void MethodSumlim()
        {
            input = double.Parse(txtInput.Text);
            double outputSumlim = 0;
            double count = 1;

            while (count <= input)
            {
                outputSumlim += (double)1 / (double)count;
                count++;
            }
            txtSumLimit.Text = outputSumlim.ToString("N2");
        }

        private void MethodSumOdd()
        {
            input = double.Parse(txtInput.Text);
            double outputSumOdd = 0;
            double sum = 0;
            double count = 1;

            while (count <= input)
            {
                sum += count;
                outputSumOdd += sum;
                count += 2;
            }
            txtSumOdd.Text = outputSumOdd.ToString("N2");
        }

        private void MethodProdOdd()
        {
            input = double.Parse(txtInput.Text);
            double outputProdOdd = 1;
            double sum = 0;
            double count = 1;

            while (count <= input)
            {
                sum += count;
                outputProdOdd *= sum;
                count+=2;
            }
            txtProductOdd.Text = outputProdOdd.ToString("N2");
        }





    }
}
