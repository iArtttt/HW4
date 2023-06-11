namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Client vasya = new Client("Vasya","Pupkin");
            Client igor = new Client("Igor", "Kuzmich");

            bank.ClientAdd(vasya);
            bank.ClientAdd(igor);
            bank.ClientAdd(vasya);

            bank.OpenBill();
            bank.OpenBill();
            bank.OpenBill();



            Console.Write("Write your bill: ");
            int myBill = int.Parse(Console.ReadLine());
            bank.ConnectBill(vasya, myBill);
            Console.Write("Write his bill: ");
            int hisBill = int.Parse(Console.ReadLine());
            bank.ConnectBill(igor,hisBill);
            Console.Write("Write my persent: ");
            decimal np = decimal.Parse(Console.ReadLine());
            Console.Write("Write his persent: ");
            decimal np1 = decimal.Parse(Console.ReadLine());

            bank.SetPercent(np,myBill);
            bank.SetPercent(np1,hisBill);



            vasya.PersonalBills[myBill].PutMoneyOnBalance(56654.56m);

            Console.WriteLine();
            vasya.PersonalBills[myBill].ShowBalanse();
            igor.PersonalBills[hisBill].ShowBalanse();
            Console.WriteLine();
            vasya.PersonalBills[myBill].SendMoneyTo(vasya,igor,65.68m,hisBill);
            vasya.PersonalBills[myBill].ShowBalanse();
            igor.PersonalBills[hisBill].ShowBalanse();
            Console.WriteLine();
            igor.PersonalBills[hisBill].SendMoneyTo(igor,vasya,15.6m,myBill);
            vasya.PersonalBills[myBill].ShowBalanse();
            igor.PersonalBills[hisBill].ShowBalanse();



            bank.GetAllBankBills();
            bank.GetAllClients();
        }
    }
}