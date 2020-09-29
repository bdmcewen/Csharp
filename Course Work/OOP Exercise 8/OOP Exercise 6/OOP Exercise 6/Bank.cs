using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Bank
    {
        //attributes
        List<Member> MembersList = new List<Member>();
        public int Transactions { get; set; }

        // Changed gross balance to private to prevent access from outide the class.
        private decimal GrossBalance { get; set; }

        //constructors
        public Bank(int transactions, decimal grossBalance)
        {
            this.Transactions = transactions;
            this.GrossBalance = grossBalance;
        }

        // changed to private to prevent changes from outside the class
        private static int GenRando()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int randNum = r.Next(100000, 999999);
            return randNum;
        }

        public void GenerateMembers()
        {

            for (int i = 1; i < 11; i++)
            {             
                Member m = new Member();
                m.Checking.AccountId = GenRando();            
                m.Saving.AccountId = (m.Checking.AccountId + 1);
                this.MembersList.Add(m);
            }

        }

        public void DisplayMembers()
        {
            foreach(Member m in MembersList)
            {
                Console.WriteLine(m.GetName());
            }
        }

        public void GetAccountTypeCount()
        {
            Console.WriteLine();
            int counterChecking = 1;
            int counterSaving = 1;
            foreach (Member m in MembersList)
            {
                //could use if loop to only count/display accounts with Balance !=0 ($25 required to open account, 0 balance indicates inactive account)
                /*
                if (m.Checking.Balance != 0)
                {

                }
                */
                /*
                Console.WriteLine(
                    "{0,3} {1,6} {2,1} {3,-8} ",
                    counterChecking,
                    m.Checking.AccountId,
                    ":",
                    m.Checking.Type);
                    */
                counterChecking++;
            }

            foreach (Member m in MembersList)
            {
                /*
                if (m.Saving.Balance != 0)
                {

                }
                */
                /*
                Console.WriteLine(
                    "{0,3} {1,6} {2,1} {3,-8}",
                    counterSaving,
                    m.Saving.AccountId,
                    ":" ,
                    m.Saving.Type );
                    */

                counterSaving++;
            }
            Console.WriteLine();
            Console.WriteLine("There are " + (counterChecking-1).ToString() + " Checking accounts.");
            Console.WriteLine("There are " + (counterSaving-1).ToString() + " Saving accounts.");
            Console.WriteLine();
        }

        public void GetTransactionCounter()
        {
            foreach(Member m in MembersList)
            {
                Transactions += (m.Checking.TransactionCounter + m.Saving.TransactionCounter);
            }
            Console.WriteLine("Current Number of Transactions:" + Transactions);
        }

        public decimal GetGrossBalance()
        {
            foreach(Member m in MembersList)
            {
                GrossBalance += m.Checking.GetBalance();
                GrossBalance += m.Saving.GetBalance();
            }

            return GrossBalance;
        }

        

    }
}
