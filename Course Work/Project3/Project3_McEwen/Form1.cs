using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_McEwen
{
    public partial class Form1 : Form
    {
        int TotalCalories;
        int TotalFat;
        int TotalProtein;
        int TotalSodium;
        Double TotalPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureChickenSandwhich_Click(object sender, EventArgs e)
        {
            TotalCalories += 440;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 19;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 28;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 1350;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 3.05;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("Chicken Sandwich $3.05");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TotalCalories += 260;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 12;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 28;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 980;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 4.45;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("Chicken Nugets $4.45");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TotalCalories += 260;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 0;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 0;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 90;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 2.75;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("CoCa Cola $2.75");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TotalCalories += 360;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 18;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 5;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 280;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 1.85;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("Waffle Fries $1.85");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TotalCalories += 330;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 14;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 27;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 670;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 7.19;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("Chicken Salad $7.19");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TotalCalories += 260;
            txtTotalCalories.Text = TotalCalories.ToString();
            TotalFat += 0;
            txtTotalFat.Text = TotalFat.ToString() + "g";
            TotalProtein += 0;
            txtTotalProtein.Text = TotalProtein.ToString() + "g";
            TotalSodium += 90;
            txtTotalSodium.Text = TotalSodium.ToString() + "mg";
            TotalPrice += 2.75;
            txtTotalPrice.Text = TotalPrice.ToString("C");
            lstBox.Items.Add("Dr. Pepper $2.75");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotalCalories.Text = "";
            txtTotalFat.Text = "";
            txtTotalProtein.Text = "";
            txtTotalSodium.Text = "";
            txtTotalPrice.Text = "";
            lstBox.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
