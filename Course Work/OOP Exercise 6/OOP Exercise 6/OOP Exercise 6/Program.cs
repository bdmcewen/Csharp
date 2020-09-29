using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank onestBank = new Bank(0, 0.00m);           

            onestBank.GenerateMembers();
            onestBank.DisplayMembers();
            onestBank.GetAccountTypeCount();
            onestBank.GetTransactionCounter();

            Console.WriteLine("Press Any Key to Exit.");
            Console.Read();
        }
    }
}
