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

namespace Project6_McEwen
{
    public partial class Form1 : Form
    {
        
        public  Form1()
        {
            InitializeComponent();
        }

        private void BtnAscending_Click(object sender, EventArgs e)
        {
            MethodAscending();
            MethodlblMain_Click();
        }

        private void MethodAscending()
        {
            lstBxOutput.Items.Clear();
            try
            {
                // Creates an array to hold items read from file.
                const int SIZE = 52;
                string[] names = new string[SIZE];

                // Counter Variable to be used in loop
                int index = 0;

                // Declares a StreamReader Variable
                StreamReader inputFile;

                // Opens file and gets Streamreader Object
                inputFile = File.OpenText("winners.txt");

                // Reads the file contents into the array
                while (index < names.Length && !inputFile.EndOfStream)
                {
                    names[index] = inputFile.ReadLine();
                    index++;
                }

                // Closes file
                inputFile.Close();

                //Sorts String Array
                Array.Sort(names);

                // Displays the arrays elements into the list box
                foreach (string value in names)
                {
                    lstBxOutput.Items.Add(value);
                }

            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            }
        }

        private void BtnDescending_Click(object sender, EventArgs e)
        {
            MethodDescending();
            MethodlblMain_Click();

        }

        private void MethodDescending()
        {
            lstBxOutput.Items.Clear();
            try
            {
                // Creates an array to hold items read from file.
                const int SIZE = 52;
                string[] names = new string[SIZE];

                // Counter Variabel to be used in loop
                int index = 0;

                // Declares a StreamReader Variable
                StreamReader inputFile;

                // Opens file and gets Streamreader Object
                inputFile = File.OpenText("winners.txt");

                // Reads the file contents into the array
                while (index < names.Length && !inputFile.EndOfStream)
                {
                    names[index] = inputFile.ReadLine();
                    index++;
                }

                // Closes file
                inputFile.Close();

                //Sorts String Array
                Array.Sort(names);
                Array.Reverse(names);

                // Displays the arrays elements into the list box
                foreach (string value in names)
                {
                    lstBxOutput.Items.Add(value);
                }

            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            }
        }

        private void BtnShowYears_Click(object sender, EventArgs e)
        {
            MethodYearNames();
            MethodlblMain_Click();
        }

        private void MethodYearNames()
        {
            lstBxOutput.Items.Clear();
            try
            {
                // Creates an array to hold items read from file.
                const int SIZE = 52;
                string[] datenames = new string[SIZE];

                // Counter Variabel to be used in loop
                int index = 0;

                // Declares a StreamReader Variable
                StreamReader inputFile;

                // Opens file and gets Streamreader Object
                inputFile = File.OpenText("winnersdates.txt");

                // Reads the file contents into the array
                while (index < datenames.Length && !inputFile.EndOfStream)
                {
                    datenames[index] = inputFile.ReadLine();
                    index++;
                }

                // Closes file
                inputFile.Close();

                //Sorts String Array
                Array.Sort(datenames);

                // Displays the arrays elements into the list box
                String[] winnerbyyear = File.ReadAllLines("winnersdates.txt");

                var teambyyear = from year in winnerbyyear
                                 let winyear = year.Split(',')
                                 let time = winyear[0]
                                 let name = winyear[1]
                                 select new { time, name };

                foreach (var team in teambyyear)
                {
                    lstBxOutput.Items.Add(team.time + " the winner was " + team.name);
                }

            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            }
        }

        private void BtnRemoveDups_Click(object sender, EventArgs e)
        {
            MethodRemoveDups();
            MethodlblMain_Click();
        }

        private void MethodRemoveDups()
        {
            lstBxOutput.Items.Clear();
            try
            {
                // Creates an array to hold items read from file.
                const int SIZE = 52;
                string[] names = new string[SIZE];

                // Counter Variabel to be used in loop
                int index = 0;

                // Declares a StreamReader Variable
                StreamReader inputFile;

                // Opens file and gets Streamreader Object
                inputFile = File.OpenText("winners.txt");

                // Reads the file contents into the array
                while (index < names.Length && !inputFile.EndOfStream)
                {
                    names[index] = inputFile.ReadLine();
                    index++;
                }

                // Closes file
                inputFile.Close();

                //Removes Duplicates from array
                names = new HashSet<string>(names).ToArray();

                //Sorts String Array
                Array.Sort(names);

                // Displays the arrays elements into the list box
                foreach (string value in names)
                {
                    lstBxOutput.Items.Add(value);
                }

            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            } 
        }

        private void btn1xChamps_Click(object sender, EventArgs e)
        {
            MethodOneTime();
            MethodlblMain_Click();
        }

        private void MethodOneTime()
        {
            lstBxOutput.Items.Clear();
            try
            {
                // Creates an array to hold items read from file.
                const int SIZE = 52;
                string[] namesList = new string[SIZE];

                // Counter Variabel to be used in loop
                int index = 0;

                // Declares a StreamReader Variable
                StreamReader inputFile;

                // Opens file and gets Streamreader Object
                inputFile = File.OpenText("winners.txt");

                // Reads the file contents into the array
                while (index < namesList.Length && !inputFile.EndOfStream)
                {
                    namesList[index] = inputFile.ReadLine();
                    index++;
                }

                // Closes file
                inputFile.Close();

                //Selects Unique values
                int numChamps = 1;

                string[] teams = File.ReadAllLines("winners.txt");

                List<string> teamCounter = new List<string>();

                foreach (string team in teams)
                {
                    for (int counter = 0; counter < teams.Length; counter++)
                    {
                        if (teams[counter] == team)
                        {
                            teamCounter.Add(teams[counter]);
                        }
                    }

                    // Displays the arrays elements into the list box
                    if (teamCounter.Count == numChamps)
                    {
                        lstBxOutput.Items.Add(teamCounter[0]);
                    }
                    teamCounter.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            }
        }
        
        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstBxOutput.Items.Clear();
            TxtBoxChamps.Text = "";
            TxtBoxYear.Text = "";
            lblnumTeams.Text = "";
        }

        private void btnCalcChamp_Click(object sender, EventArgs e)
        {
            MethodCalcChamp();
            MethodlblMain_Click();

        }

        private void MethodCalcChamp()
        {
            lstBxOutput.Items.Clear();

            try
            {
                int numChamps = int.Parse(TxtBoxChamps.Text);

                string[] teams = File.ReadAllLines("winners.txt");

                List<string> teamCounter = new List<string>();

                foreach (string team in teams)
                {
                    for (int counter = 0; counter < teams.Length; counter++)
                    {
                        if (teams[counter] == team)
                        {
                            teamCounter.Add(teams[counter]);
                        }
                    }

                    if (teamCounter.Count == numChamps)

                    {
                        if (!lstBxOutput.Items.Contains(teamCounter[0]))
                        {
                            lstBxOutput.Items.Add(teamCounter[0]);
                        }
                    }
                    teamCounter.Clear();
                }
            }
                catch
            {
                MessageBox.Show(" Your doing it wrong.");
            }
            
        }

        private void btnCalcYears_Click(object sender, EventArgs e)
        {
            MethodCalcYears();
            MethodlblMain_Click();
        }

        private void MethodCalcYears()
        {
            lstBxOutput.Items.Clear();

            try
            {
                int Year = int.Parse(TxtBoxYear.Text);

                String[] winnerbyyear = File.ReadAllLines("winnersdates.txt");

                var teambyyear = from year in winnerbyyear
                                 let winyear = year.Split(',')
                                 let time = winyear[0]
                                 let name = winyear[1]
                                 select new { time, name };

                foreach (var team in teambyyear)
                {
                    if (int.Parse(team.time) == Year)
                    {
                        lstBxOutput.Items.Add(" The winner was " + team.name);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Your doing it wrong.");
            }
        }

        private void MethodlblMain_Click()
        {
            string numTeams = "";

            numTeams = lstBxOutput.Items.Count.ToString();

            lblnumTeams.Text = "The number of teams was " + numTeams;
        }

        private void lblnumTeams_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("your me3ssage Here");
            }
        }
    }
}
