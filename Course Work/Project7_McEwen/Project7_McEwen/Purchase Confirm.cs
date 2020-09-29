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
using System.Text.RegularExpressions;


namespace Project7_McEwen
{
    public partial class Purchase_Confirm : Form
    {
        bool csvchecker = true;
        bool ccnumber = true;
        public Purchase_Confirm()
        {
            InitializeComponent();
            Totalcost();

        }

        private void CsvChecker()
        {
            String CSVNum = TxtboxCCcsv.Text;
            Regex Numonly = new Regex("\\d+");
            Match match = Numonly.Match(CSVNum);
            if (match.Success &&CSVNum.Length == 3)
            {
                csvchecker = true;
            }
            else
            {
                csvchecker = false;
                MessageBox.Show("CSV has been entered incorrectly");
            }

        }

        private void CCnumber()
        {
            String CSVNum = TxtboxCCnumber.Text;
            Regex Numonly = new Regex("\\d+");
            Match match = Numonly.Match(CSVNum);
            if (match.Success && CSVNum.Length == 16)
            {
                ccnumber = true;
            }
            else
            {
               ccnumber = false;
                MessageBox.Show("CSV has been entered incorrectly");
            }

        }

        private void Totalcost()
        {
            LblTotCost.Text = Customer.TotalCost.ToString("C");
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            LblTotCost.Text =  Customer.TotalCost.ToString("C");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (csvchecker ==true && ccnumber == true)
            {
                string CCnumber = TxtboxCCnumber.Text;
                string CCname = TxtboxCCName.Text;
                string CCcsv = TxtboxCCcsv.Text;

                Customer.CCNumber = CCnumber;
                Customer.CCName = CCname;
                Customer.CCcsv = CCcsv;

                //get Random number            
                Random r = new Random();
                int randNum = r.Next(1000, 9999);

                //Loads array.           
                string[] CustomerArray = new string[11];
                CustomerArray[0] = Customer.Name;
                CustomerArray[1] = Customer.Email;
                CustomerArray[2] = Customer.Age.ToString();
                CustomerArray[3] = Customer.CCNumber.ToString();
                CustomerArray[4] = Customer.CCName;
                CustomerArray[5] = Customer.CCcsv.ToString();
                CustomerArray[6] = Customer.TotalCost.ToString();
                CustomerArray[7] = Customer.LowLevel.ToString();
                CustomerArray[8] = Customer.ClubLevel.ToString();
                CustomerArray[9] = Customer.UpperLevel.ToString();
                CustomerArray[10] = randNum.ToString();


                DialogResult result = MessageBox.Show("Can't wait t see you!" + CCname + "\n" + "Summary:" + "\n" + "Amount to be Charged:" +
                    Customer.TotalCost.ToString("C") + "\n" + "contact e-mail:" + Customer.Email, "\n" + "\n" + "Please click YES To confirm " +
                    "your order", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Thank you for your order!" + "\n" + "Your confirmation number is: " + randNum);
                    string CustomerLoad = string.Join(",", CustomerArray);

                    //load info into data file.                    
                    File.AppendAllText("CustomerInfo.txt", CustomerLoad + "\r\n");

                    //reads all lines from .txt file into a string
                    string seatsASstring = File.ReadAllText("SeatsRemaining.txt");

                    // tokenizes string and splits at commas to an array
                    string[] tokens = seatsASstring.Split(',');

                    //converts string array to int arrray
                    int[] seatsASint = Array.ConvertAll<string, int>(tokens, int.Parse);

                    //subtracts number of seats purchased from number of seats avaiable
                    seatsASint[0] -= int.Parse(Customer.LowLevel);
                    seatsASint[1] -= int.Parse(Customer.ClubLevel);
                    seatsASint[2] -= int.Parse(Customer.UpperLevel);

                    // converts ammended int array to string array with new values
                    string[] antitokens = seatsASint.Select(x => x.ToString()).ToArray();

                    //joines array into new string
                    string newseatsASstring = String.Join(",", antitokens);

                    //writes new string array to original file
                    File.WriteAllText("SeatsRemaining.txt", newseatsASstring);

                    this.Close();
                }

                else if (result == DialogResult.No)
                {
                    //closes by default on no
                }
            }
        }
    }   
}
