using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        public List<Client> Clients = new List<Client>();
        public List<Bill> Bills { get; set;}

        public void OpenBill()
        {
            Bill bill = new Bill();
            Bills.Add(bill);
        }
        public void ConnectBill(Client client, Bill bill)
        {
            Clients[Clients.IndexOf(client)].Bills.Add(bill);
        }
        public void ClientAdd(Client client)
        {
            if (!Clients.Contains(client))
                Clients.Add(client);
            //Clients.Add(new Client());
        }
        public void ClientRemove(Client client)
        {
            if (Clients.Contains(client))
                Clients.Remove(client);
        }
    }
}
