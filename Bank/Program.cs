namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Client client = new Client();
            Client client1 = new Client();

            bank.ClientAdd(client);
            bank.ClientAdd(client1);
            bank.ClientAdd(client);

            //Console.WriteLine("Hello, World!");
            //Money money = new Money(2,0.1f);
            //Money money2 = new Money(4,0.4f);
            //Money money1 = money + money2;
            //Console.WriteLine(money1.UAH);
            //Console.WriteLine(money1.Penny);
            //bool s = money == money2;


        }
    }
}