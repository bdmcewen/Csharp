using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public double Statetax { get; private set; }
        public double Federaltax { get; private set; }
        public object Netincome { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buttonclear_Click(object sender, EventArgs e)
        {
            txtgrossincome.Text = "";
            txtstatetax.Text = "";
            txtfederaltax.Text = "";
            txtnetincome.Text = "";
            txtgrossincome.Focus();
        }

        private void Buttoncalculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                int grosincome = int.Parse(txtgrossincome.Text);

                double grossincome;
                double netincome;
                double statetax;
                double federaltax;

                grossincome = double.Parse(txtgrossincome.Text);
                statetax = grossincome * .03;
                federaltax = grossincome * .09;
                netincome = grossincome - (federaltax + statetax);

                txtnetincome.Text = netincome.ToString("c");
                txtstatetax.Text = statetax.ToString("c");
                txtfederaltax.Text = federaltax.ToString("c");

            }
            catch
            {
                MessageBox.Show("Error – Input must be a numeric value");
            }
            
            

    

                }
            }
        }
    
