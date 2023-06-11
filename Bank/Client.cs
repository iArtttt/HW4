using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Client
    {
        public string Name { get; }
        public string LastName { get; }
        public Dictionary<int, Bill> PersonalBills { get; }

        public Client(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
            PersonalBills = new Dictionary<int, Bill>();
        }
        public void ShowMyBalanseOnTheBill(int billId)
        {
            PersonalBills[billId].ShowBalanse();
        }
        public void ShowAllTransactions()
        {
            foreach (var bill in PersonalBills.Values)
            {
                Transaction.ShowAllTransactions(bill);
            }
        }
        public void ShowLastTransactions(int bill)
        {
            Transaction.ShowLastTransactions(PersonalBills[bill]);
        }
    }
}
