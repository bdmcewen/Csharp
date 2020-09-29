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
    public partial class AccountCreation : Form
    {

        bool errorcheck = true;

        public AccountCreation()
        {
            InitializeComponent();
        }

        public void Errorchecks()
        {
            int age = int.Parse(TxtBoxAge.Text);
            string usrEmail = TxtBoxEmail.Text;

            String[] userinfo = File.ReadAllLines("CustomerAccounts.txt");

            //age verification
            if (age <= 16 )
            {
                MessageBox.Show("This is a 16 and over event");
                errorcheck = false;
            }
            // checks for duplicate email
            if (usrEmail == userinfo[2])
            {
                MessageBox.Show("This email is already in use");
                errorcheck = false;
            }
            
            //checks email for @ and .
            if (!TxtBoxEmail.Text.Contains('@') || !TxtBoxEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorcheck = false;
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {

            string usrEmail = TxtBoxEmail.Text;

            //Creates string array to hold customer info
            string[] CustomerInfo = new string[6];

            CustomerInfo[0] = TxtBoxName.Text;
            CustomerInfo[1] = TxtBoxAge.Text;
            CustomerInfo[2] = TxtBoxEmail.Text;
            CustomerInfo[3] = TxtBoxPassword.Text;
            Errorchecks();

            String[] userinfo = File.ReadAllLines("CustomerAccounts.txt");

            var customerinfo = from item in userinfo
                               let namePwrd = item.Split(',')
                               // let username = namePwrd[0]
                               let useremail = namePwrd[2]
                               // let userpwrd = namePwrd[3]
                               select new { useremail };

            if (errorcheck == true)
            {
                MessageBox.Show("Hello, " + CustomerInfo[0]);

                string CustomerRecord = string.Join(",", CustomerInfo);
                MessageBox.Show("Account Created, " + CustomerRecord);

                File.AppendAllText("CustomerAccounts.txt", CustomerRecord + "\r\n");

                new User_Login().Show();
            }
            else
            {
                MessageBox.Show("This email is already in use");
            }
            
        }
    }
}
