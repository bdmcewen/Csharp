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
    public partial class Admin : Form
    {

        double lltotalseats = 0;
        double cltotalseats = 0;
        double udtotalseats = 0;
        double totalsales = 0;


        public Admin()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            String[] customers = File.ReadAllLines("CustomerInfo.txt");

            var gridquery = from item in customers
                            let getdata = item.Split(',')
                            let getname = getdata[0]
                            let useremail = getdata[1]
                            let gettotalcost = getdata[6]
                            let getconfirm = getdata[10]
                            let ll = getdata[7]
                            let cl = getdata[8]
                            let ud = getdata[9]
                            let sales = getdata[6]
                            select new { getname, useremail, gettotalcost, getconfirm, ll, cl, ud, sales };

            foreach (var name in gridquery)
            {
                // loads data into grid
                dataGridView1.Rows.Add(name.getname, name.useremail, name.gettotalcost, name.getconfirm, name.ll, name.cl, name.ud, name.sales);

                // Totals
                lltotalseats += double.Parse(name.ll);
                cltotalseats += double.Parse(name.cl);
                udtotalseats += double.Parse(name.ud);
                totalsales += double.Parse(name.sales);
            }
            // displays seats remaining
            lblll.Text = (200 - lltotalseats).ToString();
            lblcl.Text = (75 - cltotalseats).ToString();
            lblud.Text = (200 - udtotalseats).ToString();
            lblttlcost.Text = totalsales.ToString("C2");

        }

        private void Randos()
        {
            String[] customers = File.ReadAllLines("CustomerInfo.txt");

            string confirmnum = txtconfirmsearch.Text;

            var confirmquery = from item in customers
                               let seattotal = item.Split(',')
                               let searchname = seattotal[0].ToUpper()
                               let ll = seattotal[7]
                               let cl = seattotal[8]
                               let ud = seattotal[9]
                               let amtcharged = seattotal[6]
                               let confirm = seattotal[10]
                               select new { searchname, amtcharged, ll, cl, ud, confirm };

            foreach (var result in confirmquery)
            {
                if (confirmnum == result.confirm)
                {
                    MessageBox.Show("Found Confirmmation Number: " + result.confirm + "\n" + result.searchname);
                }
            }
            //highlights row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(confirmnum))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Confirmation Number Does Not Exist!", "number not found");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Randos();
        }
    }
}
