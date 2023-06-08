namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Client Artur = new Client("Artur","Svichkar");
            Client Max = new Client("Maxim", "Zubrov");

            bank.ClientAdd(Artur);
            bank.ClientAdd(Max);
            bank.ClientAdd(Artur);

            bank.OpenBill();
            bank.OpenBill();
            bank.OpenBill();



            Console.Write("Write your bill: ");
            int myBill = int.Parse(Console.ReadLine());
            bank.ConnectBill(Artur, myBill);
            Console.Write("Write his bill: ");
            int hisBill = int.Parse(Console.ReadLine());
            bank.ConnectBill(Max,hisBill);
            Console.Write("Write my persent: ");
            decimal np = decimal.Parse(Console.ReadLine());
            Console.Write("Write his persent: ");
            decimal np1 = decimal.Parse(Console.ReadLine());

            bank.SetPercent(np,myBill);
            bank.SetPercent(np1,hisBill);



            Artur.PersonalBills[myBill].PutMoneyOnBalance(56654.56m);

            Console.WriteLine();
            Artur.PersonalBills[myBill].ShowBalanse();
            Max.PersonalBills[hisBill].ShowBalanse();
            Console.WriteLine();
            Artur.PersonalBills[myBill].SendMoneyTo(Artur,Max,65.68m,hisBill);
            Artur.PersonalBills[myBill].ShowBalanse();
            Max.PersonalBills[hisBill].ShowBalanse();
            Console.WriteLine();
            Max.PersonalBills[hisBill].SendMoneyTo(Max,Artur,15.6m,myBill);
            Artur.PersonalBills[myBill].ShowBalanse();
            Max.PersonalBills[hisBill].ShowBalanse();



            bank.GetAllBankBills();
            bank.GetAllClients();
            //decimal amount = decimal.Parse(Console.ReadLine());

            //Bill bill = new Bill(6666666);
            //bill.PutMoneyOnBalance(amount);

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