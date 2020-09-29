using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Account
    {

        // Attributes
        public int AccountId { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public int TransactionCounter { get; set; }

        // Constructors

        //generic
        public Account(int accountId,string type, decimal balance, int transactionCounter)
        {
            this.AccountId = accountId;
            this.Type = type;
            this.Balance = balance;
            this.TransactionCounter = transactionCounter;
        }

        //instantiates with default values( to avoid Null exception)
        public Account(string type)
        {
            this.AccountId = 000000;
            this.Type = "";
            this.Balance = 25.00M;
            this.TransactionCounter = 1;
        }

        // Methods

        // zeros out balance as object cannot be uninstantiated
        public void CloseAccount()
        {            
            this.Balance -= this.Balance;
            TransactionCounter++;
        }

        public void AddFunds()
        {
            Console.WriteLine("Please enter amount of deposit:");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Balance += deposit;
            TransactionCounter++;

            Console.WriteLine("the new Balance is:" + Balance.ToString());
            
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public int GetTransactionCount()
        {
            return this.TransactionCounter;
        }
    }
}
