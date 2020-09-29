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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usrName = (TxtboxUname.Text);
            string usrPwrd = (TxtboxPwrd.Text);

            String[] puserinfo = File.ReadAllLines("AdminAccounts.txt");

            var admininfo = from name in puserinfo
                            let namePwrd = name.Split(',')
                            let username = namePwrd[1]
                            let userpwrd = namePwrd[3]
                            select new { username, userpwrd};

            foreach (var word in admininfo)
            {
                if ((word.userpwrd) == usrPwrd && (word.username) == usrName)
                {
                    new Admin().Show();
                }
            }
        }
    }
}
