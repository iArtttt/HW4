using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal struct Transaction
    {
        public readonly List<string> TransactionStory;
        public string LastTransaction { get; set; }

        public Transaction()
        {
            TransactionStory = new List<string>();
        }
        public static void TakeMoney()
        {

        }
        public static void SendMoneyTo()
        {

        }
        public void ShowAllTransactions()
        {
            foreach (var transaction in TransactionStory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
