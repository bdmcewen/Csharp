using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_McEwen
{
    public partial class Form1 : Form
    {
        double PackageWeight;
        double ShippingDistance;
        double ShippingCost;
       
        bool errorcheck = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void errorchecks()
        {
            if (ShippingDistance <= 0)
            {
                MessageBox.Show("Shipping Distance must be greater than 0");
                errorcheck = false;
            }

            if (PackageWeight <= 0)
            {
                MessageBox.Show("Package Weight must be greater than 0");
                errorcheck = false;
            }

            if (PackageWeight > 25 && RdoBtnUSPS.Checked == true)
            {
                MessageBox.Show("Shipping weight for USPS must not exceed 25 ");
                errorcheck = false;
            }

            if (RdoBtnUPS.Checked == false && RdoBtnFEDEX.Checked == false && RdoBtnUSPS.Checked == false)
            {
                MessageBox.Show("Please Select a carrier");
                errorcheck = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                PackageWeight = double.Parse(txtPackageWeight.Text);
                ShippingDistance = double.Parse(txtShippingDistance.Text);
                errorchecks();

                if (errorcheck == true)
                {
                    if (RdoBtnUPS.Checked == true)
                    {
                        MethodUPS();
                    }

                    else if (RdoBtnFEDEX.Checked == true)
                    {
                        MethodFEDEX();
                    }

                    else
                    {
                        MethodUSPS();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error – input must be a numeric value greater than 0");
            }




        }

        private void MethodUPS()
        {
            lblupcharge.Visible = false;
            lblupcharge.Text = "Note: Mileage upcharge of";

            if (ShippingDistance > 0 && ShippingDistance <= 500)
            {
                ShippingCost = (PackageWeight * 6.4);
            }

            else if (ShippingDistance <= 1000)
            {
                ShippingCost = (PackageWeight * 5.75);
            }

            else
            {
                ShippingCost = (PackageWeight * 4.5);
            }

            lbloutput.Text = ShippingCost.ToString("C");

        }

        private void MethodFEDEX()
        {
            double PackageWeight;
            double ShippingDistance;
            double ShippingCost;
            lblupcharge.Visible = false;
            lblupcharge.Text = "Note: Mileage upcharge of";

            try
            {
                PackageWeight = double.Parse(txtPackageWeight.Text);
                ShippingDistance = double.Parse(txtShippingDistance.Text);

                if (ShippingDistance > 0 && ShippingDistance <= 500)
                {
                    ShippingCost = PackageWeight * 4.75;
                }
                else if (ShippingDistance <= 1000)
                {
                    ShippingCost = PackageWeight * 9.75;
                }
                else
                {
                    ShippingCost = PackageWeight * 14.5;
                }
                lbloutput.Text = ShippingCost.ToString("C");
            }
            catch
            {
                MessageBox.Show("Error – input must be a numeric value greater than 0");
            }

        }

        private void MethodUSPS()
        {
            ShippingCost = 0.00;
            lblupcharge.Visible = false;
            lblupcharge.Text = "Note: Mileage upcharge of";

            if (ShippingDistance > 0 && ShippingDistance <= 500)
            {
                if (PackageWeight <= 1)
                {
                    ShippingCost = (PackageWeight * 3.90);
                }
                else if (ShippingDistance <= 10)
                {
                    ShippingCost = (PackageWeight * 1.75);
                }
                else
                {
                    ShippingCost = (PackageWeight * 1.25);
                }
            }

            else
            {
                lblupcharge.Visible = true;

                if (PackageWeight <= 1)
                {
                    ShippingCost = PackageWeight * (3.90 + 1.25);
                }
                else if (ShippingDistance <= 10)
                {
                    ShippingCost = PackageWeight * (1.75 + 1.25);
                }
                else
                {
                    ShippingCost = PackageWeight * (1.50 + 1.25);
                }
            }

                lbloutput.Text = ShippingCost.ToString("c");
                lblupcharge.Text += (PackageWeight * 1.25).ToString("c");
        }

        private void TxtPackageWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void LlblClear_Click(object sender, EventArgs e)
        {
            txtPackageWeight.Text = "";
            txtShippingDistance.Text = "";
            ShippingCost = 0.00;
            RdoBtnUPS.Checked = false;
            RdoBtnFEDEX.Checked = false;
            RdoBtnUSPS.Checked = false;
            lbloutput.Text = "$0.00";
            lblupcharge.Text = "Note: Mileage upcharge of";
            lblupcharge.Visible = false;
            errorcheck = true;
            txtPackageWeight.Focus();
        }

        private void TxtShippingDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
