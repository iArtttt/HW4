using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Client
    {
        public string Name { get; set; }
        public string lastName { get; set; }
        public List<Bill> Bills { get; set;}
        Transaction PersonalTransactions;
        
        public Client()
        {
            PersonalTransactions = new Transaction();
        }
        public void SS()
        {
            PersonalTransactions.ShowAllTransactions();
        }
    }
}
