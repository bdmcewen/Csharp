using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project7_McEwen
{
    public partial class Tickets : Form
    {
        public Tickets()
        {

            InitializeComponent();
            lblSOLowerlvl.Visible = false;
            lblSOClublvl.Visible = false;
            lblSOUpperlvl.Visible = false;
            lblLowerlvl.Visible = true;
            lblClublvl.Visible = true;
            lblUpperlvl.Visible = true;

            // separates string into sections
            string[] availableseats = File.ReadAllLines("SeatsRemaining.txt");

            var seatsleft = from section in availableseats
                               let seats = section.Split(',')
                               let llseats = seats[0]
                               let clseats = seats[1]
                               let ulseats = seats[2]
                               select new { llseats, clseats, ulseats, };

            foreach (var number in seatsleft)
            {
                if ((number.llseats) == 0.ToString())
                {
                    lblSOLowerlvl.Visible = true;
                    comboBoxLowerlvl.Visible = false;
                    lblLowerlvl.Visible = false;
                }

                if ((number.clseats) == 0.ToString())
                {
                    lblSOClublvl.Visible = true;
                    comboBoxClublvl.Visible = false;
                    lblClublvl.Visible = false;
                }

                if ((number.ulseats) == 0.ToString())
                {
                    lblSOUpperlvl.Visible = true;
                    comboBoxUpperDeck.Visible = false;
                    lblUpperlvl.Visible = false;
                }
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            int LLevel = int.Parse(comboBoxLowerlvl.Text);
            int CLevel = int.Parse(comboBoxClublvl.Text);
            int ULevel = int.Parse(comboBoxUpperDeck.Text);

            //creates string array form file
            string[] availableseats = File.ReadAllLines("SeatsRemaining.txt"); 

            // separates string into sections
            var seatsleft = from section in availableseats
                            let seats = section.Split(',')
                            let llseats = seats[0]
                            let clseats = seats[1]
                            let ulseats = seats[2]
                            select new { llseats, clseats, ulseats, };

            foreach (var number in seatsleft)
            {
                if (int.Parse(number.llseats) >= LLevel)
                {
                    Customer.LowLevel = comboBoxLowerlvl.Text;
                    int LLcost = (LLevel * 125);
                    Customer.TotalCost += LLcost;
                }

                if (int.Parse(number.clseats) >= CLevel)
                {
                    Customer.ClubLevel = comboBoxClublvl.Text;
                    int CLcost = (CLevel * 75);
                    Customer.TotalCost += CLcost;
                }

                if (double.Parse(number.ulseats) >= ULevel)
                {
                    Customer.UpperLevel = comboBoxUpperDeck.Text;
                    int ULcost = (ULevel * 50);
                    Customer.TotalCost += ULcost;
                }

            }

            new Purchase_Confirm().Show();
        }
    }
}
