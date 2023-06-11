using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bill
    {
        public int ID { get; }
        public decimal Persent { get; private set; }
        public Money Money { get; set; }

        public Transaction Transaction = new Transaction();

        public Bill(int iD) 
        {            
            ID = iD;
        }
        public void PutMoneyOnBalance(decimal amount)
        {
            Transaction.PutMoneyOnBalance(this ,amount);
        }
        public void SendMoneyTo(Client fromThis, Client toThis, decimal howMuchToSend, int clientsBillID)
        {
            Transaction.SendMoneyFromTo(fromThis, toThis, howMuchToSend, ID, clientsBillID);

        }
        public void ShowBalanse()
        {
            Console.WriteLine($"{(decimal)Money} UAH.");
        }

        public void ChangePersent(decimal newPersent, string hawePermission)
        {
            Persent = hawePermission == "h*J^~9:#1 @!D}_+Mh1 gh9|'G]/G1>(&@&/  L&p  s/1q()_=_{}d?w{]*-+D#@H)!" ? newPersent : Persent;
        }

    }
}
