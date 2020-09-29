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
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
            TxtBoxPassword.PasswordChar = '*';
        }

        private void LinkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AccountCreation().Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usrEmail = (TxtBoxEmail.Text);
            string usrPwrd = (TxtBoxPassword.Text);

            //checks email for @ and .
            if (!TxtBoxEmail.Text.Contains('@') || !TxtBoxEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // separates string into password and username
            String[] userinfo = File.ReadAllLines("CustomerAccounts.txt");

             var customerinfo = from name in userinfo
                                let namePwrd = name.Split(',')
                                let username = namePwrd[0]
                                let userage = namePwrd [1]
                                let useremail = namePwrd[2]
                                let userpwrd = namePwrd[3]
                                select new { username, userage, useremail , userpwrd };

            //Verifies username and password match
            foreach (var word in customerinfo)
            {
                if ((word.userpwrd) == usrPwrd && (word.useremail) == usrEmail)
                {
                    Customer.Name = word.username;
                    Customer.Email = word.useremail;
                    Customer.Age = word.userage;

                    new Tickets().Show();
                }
            }
        }
    }
}
