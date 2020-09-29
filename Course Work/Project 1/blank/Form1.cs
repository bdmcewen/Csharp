using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blank
{
    public partial class frm_Project : Form
    {
        public frm_Project()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            // reset color based upon radio button setting.
            if (radio_Blue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else if (radio_Red.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (radio_White.Checked == true)
            {
                this.BackColor = Color.White;
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.BackColor = default(Color);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radHello_CheckedChanged(object sender, EventArgs e)
        {
            // Set textbox message to Hello if option is selected   
            if (radHello.Checked == true)
            {
                txtDisplayText.Text = "Hello!";
            }

        }

        private void radBonjou_CheckedChanged(object sender, EventArgs e)
        {
            // Set textbox message to Bonjour! if option is selected   
            if (radBonjour.Checked == true)
            {
                txtDisplayText.Text = "Bonjour!";
            }

        }

        private void radHola_CheckedChanged(object sender, EventArgs e)
        {
            // Set textbox message to Hola! if option is selected   
            if (radHola.Checked == true)
            {
                txtDisplayText.Text = "Hola!";
            }

        }

        private void radClear_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the textbox message if option is selected   
            if (radClear.Checked == true)
            {
                txtDisplayText.Text = "";
            }

        }
    }
}
