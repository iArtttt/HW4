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
        public string LastTransaction { get; private set; }

        public Transaction()
        {
            TransactionStory = new List<string>();
        }
        public static void TakeMoney(Bill bill ,decimal amount)
        {
            if (bill.Money <= amount) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not enough money on your balanse");
                Console.ResetColor();
                return;
            }
            bill.Money -= amount;
        }
        public static void SendMoneyFromTo(Client fromThis, Client toThis, decimal howMuchToSend, int fromThisClientsBill, int toThisClientsBill)
        {

            if (fromThis.PersonalBills[fromThisClientsBill].Money >= howMuchToSend * fromThis.PersonalBills[fromThisClientsBill].Persent)
            {
                fromThis.PersonalBills[fromThisClientsBill].Money -= howMuchToSend * fromThis.PersonalBills[fromThisClientsBill].Persent;
                fromThis.PersonalBills[fromThisClientsBill].Transaction.AddTransactionStory($"You send {howMuchToSend} to {toThis.Name} {toThis.LastName}");

                toThis.PersonalBills[toThisClientsBill].Money += howMuchToSend;
                toThis.PersonalBills[toThisClientsBill].Transaction.AddTransactionStory($"{fromThis.Name} {fromThis.LastName} send {howMuchToSend} to {toThis.Name} {toThis.LastName}");
                


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Transaction success");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not enough money on your balanse");
                Console.ResetColor();
            }
        }

        private void AddTransactionStory(string str)
        {
            LastTransaction = str;
            TransactionStory.Add(LastTransaction);
        }

        public static void ShowLastTransactions(Bill bill)
        {
            Console.WriteLine(bill.Transaction.LastTransaction);            
        }
        public static void ShowAllTransactions(Bill bill)
        {
            foreach (var transaction in bill.Transaction.TransactionStory)
            {
                Console.WriteLine(transaction);
            }
        }

        internal static void PutMoneyOnBalance(Bill bill, decimal amount)
        {
            bill.Money += amount;
            bill.Transaction.AddTransactionStory($"{amount} was put on your balance ( Bill ID: {bill.ID} )");
        }
    }
}
