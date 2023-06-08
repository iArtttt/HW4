using Turnip.Persons;



namespace Turnip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Personality: ");
            //string personality = Console.ReadLine();
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Voise: ");
            //string voise = Console.ReadLine();
            //Console.Write("Power: ");
            //int power = int.Parse(Console.ReadLine());


            //Person person = new OwnPerson(personality, name, power, voise);

            //Console.Write($"Personality - {person.Personality}\n" +
            //    $"Name - {person.Name}\n" +
            //    $"Voise - {person.Voise}\n" +
            //    $"Power - {person.Power}");
            FairyTail fairyTail = new FairyTail();
            Console.Write("Whould you like to listen default story or make your own ( Own -> + | default -> other buttom )?\n");
            char s = Console.ReadKey().KeyChar;
            if (s == '+')
                fairyTail.OwnStoryCreate();
            else
                fairyTail.DefaultStoryStart();
        }
    }
}