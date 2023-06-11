using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnip.Persons;
using System.Threading;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Turnip
{
    internal class FairyTail
    {
        public Queue<Person> Persons { get; private set; }
        public int FullPower { get; private set; } = 0;
        public void DefaultStoryStart()
        {

            Persons = new Queue<Person>();        
            Persons.Enqueue(new GrandFather());
            Persons.Enqueue(new GrandMother());
            Persons.Enqueue(new GrandDaughter());
            Persons.Enqueue(new Dog());
            Persons.Enqueue(new Cat());
            Persons.Enqueue(new Mouse());
            Plant plant = new Plant();
            Story(plant);
        }


        public void OwnStoryCreate()
        {
            Persons = new Queue<Person>();
            Console.Write($"Would you like to have some default persons? (Yes -> +)\n");

            if (Console.ReadKey().KeyChar == '+')
            {
                Console.Write($"How many persons from default story would you like to have ( 1 - 6 )?\n");
                int defoultPersons = int.TryParse(Console.ReadLine(), out int defoultPersonsResult) ? defoultPersonsResult : 0;
                
                if ( defoultPersons == 1 ) 
                    Persons.Enqueue(new GrandFather());
                if ( defoultPersons == 2 )
                {
                    Persons.Enqueue(new GrandFather());
                    Persons.Enqueue(new GrandMother());
                }
                if ( defoultPersons == 3)
                {
                    Persons.Enqueue(new GrandFather());
                    Persons.Enqueue(new GrandMother());
                    Persons.Enqueue(new GrandDaughter());
                }
                if ( defoultPersons == 4)
                {
                    Persons.Enqueue(new GrandFather());
                    Persons.Enqueue(new GrandMother());
                    Persons.Enqueue(new GrandDaughter());
                    Persons.Enqueue(new Dog());
                }
                if ( defoultPersons == 5)
                {
                    Persons.Enqueue(new GrandFather());
                    Persons.Enqueue(new GrandMother());
                    Persons.Enqueue(new GrandDaughter());
                    Persons.Enqueue(new Dog());
                    Persons.Enqueue(new Cat());
                }
                if ( defoultPersons == 6)
                {
                    Persons.Enqueue(new GrandFather());
                    Persons.Enqueue(new GrandMother());
                    Persons.Enqueue(new GrandDaughter());
                    Persons.Enqueue(new Dog());
                    Persons.Enqueue(new Cat());
                    Persons.Enqueue(new Mouse());
                }               
                
            }
            Console.Write($"\nHow many new persons would you like to have in your..heh story?\n");
            int countOfPersons = int.TryParse(Console.ReadLine(), out int res)?res:0;


            for ( int i = 0; i < countOfPersons; i++)
            {
                try
                {
                    Console.Write("Please write person Personality: ");
                    string personality = Console.ReadLine();
                    Console.Write("Please write person Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please write person Power: ");
                    int power = int.TryParse(Console.ReadLine(), out int powerRes) ? powerRes : 1;

                    if ( personality == "" )
                        personality = "Superhero";
                    if ( name == "" )
                        name = "Boris";

                    Persons.Enqueue(new OwnPerson(personality, name, power));

                }
                catch ( Exception e )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Was created a default person!");
                    Console.ResetColor();
                    Persons.Enqueue(new OwnPerson());
                    continue;
                }
            }
            
            Console.Write($"What plant would you like to plant?\n");
            string plantName = Console.ReadLine();
            Console.Write($"How heavy is your plant ( number )?\n");
            int plantVaight = int.TryParse(Console.ReadLine(), out int vaight) ? vaight : 5;
            Plant plant = new Plant(plantName, plantVaight);
            if (Persons.Count == 0)
                throw new Exception("No characters for this story (0_0)");

            Story(plant);
        }
        private void Story(Plant plant)
        {
            Console.Write($"\nThis is a realy sad...\n");
            Thread.Sleep(3000);
            Console.Write($"Or maybe NOT?...\n");
            Thread.Sleep(3000);
            Console.Write($"Story about the poor plant...\n");
            Thread.Sleep(3000);
            Console.Write($"And its hard life.........\n");
            Thread.Sleep(3000);
            Console.Write($"One day the ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Persons.Peek().Personality} {Persons.Peek().Name} ");
            Console.ResetColor();
            Console.Write($"planted the ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName}");
            Console.ResetColor();
            Console.Write($".\n");
            Thread.Sleep(7000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName} ");
            Console.ResetColor();
            Console.Write($"grew and grew and grew and grew and grew and grew and grew and grewwwwwwwwwwwwwwwwwww.....................\n");
            Thread.Sleep(5000);
            Console.Write($"Grew a lot. And grew up in big, ");
            Thread.Sleep(4000);
            Console.Write($"fat POTATOOOOO...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName}\n");
            Console.ResetColor();
            Thread.Sleep(3000);
            Persons.Peek().Pull(plant);
            Thread.Sleep(3000);
            Console.Write($"And ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Persons.Peek().Name} ");
            Console.ResetColor();
            Console.Write($"started pulling ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName}");
            Console.ResetColor();
            Console.Write($", pulled pulled, pulled pulled and...\n");
            Thread.Sleep(6000);
            Console.Write($"pulled pulled, pulled for a long time...\n");
            Thread.Sleep(4000);
            if (PopTry(plant))
                return;
            while (Persons.Count - 1 > 0)
            {
                Call();
                Console.Write($"And the ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{Persons.Peek().Personality} {Persons.Peek().Name} ");
                Console.ResetColor();
                Console.Write($"came and said...\n");
                Thread.Sleep(4000);
                Persons.Peek().Pull(plant);
                Thread.Sleep(2000);
                Console.Write($"And began to help\n");
                Thread.Sleep(2000);

                Console.Write($"So ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{Persons.Peek().Name} ");
                Console.ResetColor();
                Console.Write($"start pull ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{plant.PlantName}");
                Console.ResetColor();
                Console.Write($", pulled pulled, pulled pulled and...\n");
                Thread.Sleep(3000);
                Console.Write($"pulled pulled, pulled for a long time...\n");
                Thread.Sleep(2000);

                if (PopTry(plant))
                    return;
            }
            Call();
            Console.Write($"But...");
            Thread.Sleep(3000);
            Console.Write($"nobody came\n");
            Thread.Sleep(3000);
            Console.Write($"So {plant.PlantName} remained in the ");
            Thread.Sleep(5000);
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"dark ");
            Thread.Sleep(1000);
            Console.Beep();
            Console.Write($"cold ");
            Thread.Sleep(1000);
            Console.Beep();
            Console.Write($"earth\n");
            Thread.Sleep(4000);
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nFOREVER\n");
            Thread.Sleep(2000);
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nAHAHHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHHA\n");
            Thread.Sleep(3000);
            Console.Beep();
            Console.Write($"HA-HA-HA\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Write($"\nMaybe next time something will change");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(2000);
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"NO");
            Console.ResetColor();
            Thread.Sleep(1000);

        }
        private void Call()
        {
            Console.Write($"So ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Persons.Peek().Name} ");
            Console.ResetColor();
            Console.Write($"send a magic unicorn with interesting massege: ( ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Persons.Dequeue().CallForHelp()} ");
            Console.ResetColor();
            Console.Write($")\n");
            Thread.Sleep(7000);
        }
        private bool PopTry(Plant plant)
        {
            if (WasPopSucced(plant))
            {
                Console.Write($"and finaly.....\n");
                Thread.Sleep(2000);
                Console.Write($"did it?");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\nYES\n");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"HAPPY END...WOOOOOOHOOOOOOOOOOOOOOOOO!!!!\n");
                Thread.Sleep(3000);
                Console.Write($"BYE   |?_?|\n\n");
                Console.ResetColor();
                Thread.Sleep(1000);
                return true;
            }
            Console.Write($"and finaly.....\n");
            Thread.Sleep(2000);
            Console.Write($"did it?");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nNO! HA-HA-HA!!!\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            return false;
        }
        private bool WasPopSucced(Plant plant)
        {
            FullPower += Persons.Peek().Power;
            return FullPower >= plant.Weight;
        }


    }
}
