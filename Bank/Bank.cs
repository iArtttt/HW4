using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        private string KeyToChangePersent = "h*J^~9:#1 @!D}_+Mh1 gh9|'G]/G1>(&@&/  L&p  s/1q()_=_{}d?w{]*-+D#@H)!";
        public readonly List<Client> Clients = new List<Client>();
        private Dictionary<int, Bill> BankBills = new Dictionary<int, Bill>();



        public void OpenBill()
        {
            int billKey = new Random().Next();
            Bill bill = new Bill(billKey);
            Console.WriteLine(billKey);
            BankBills.Add(billKey,bill);
        }
        public void ClientAdd(Client client)
        {
            if (!Clients.Contains(client))
                Clients.Add(client);
            else
                Console.WriteLine($"{client.LastName} {client.Name} is already our client");
        }
        public void ClientRemove(Client client)
        {
            if (Clients.Contains(client))
                Clients.Remove(client);
        }
        public void ConnectBill(Client client, int bill)
        {
            if (Clients.Contains(client) && BankBills.TryGetValue(bill, out Bill value))
            {
                Clients[Clients.IndexOf(client)].PersonalBills.Add(bill, value);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{client.Name} {client.LastName} does not our bank client on bill {bill} does not exist");
                Console.ResetColor();
            }
        }
        public void GetAllClients()
        {
            foreach (Client client in Clients)
            {
                Console.WriteLine($"{client.Name} {client.LastName} is in the our bank clients list");
            }
        }
        public void GetAllBankBills()
        {
            foreach (Bill bill in BankBills.Values)
            {
                Console.WriteLine($"Bill # {bill.ID}\nBill persent : {bill.Persent}");
            }
        }
        public void SetPercent(decimal newPercent, int bill)
        {
            BankBills[bill].ChangePersent(newPercent,KeyToChangePersent);
        }
    }
}
