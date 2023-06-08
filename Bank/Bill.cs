using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bill
    {
        public float Persent { get; set; }
        public Money Money { get; set; }

        public Transaction Transaction { get; set; }

        public Bill() 
        {
            Transaction = new Transaction();
        }

        public void SendMoneyTo(Bill otherBill, float howMuchToSend)
        {
            if (Money >= howMuchToSend)
            {
                otherBill.Money += howMuchToSend;
                Money -= howMuchToSend;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not enough money on your balanse");
                Console.ResetColor();
            }
        }

    }
}
