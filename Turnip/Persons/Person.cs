using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    abstract class Person
    {
        public string Personality { get; protected set; }
        public string Name { get; protected set; }
        public string CallingForHelp { get; protected set; } = string.Empty;
        public int Power { get; protected set; }
        protected Person() { }
        protected Person(string personality, string name, string callingForHelp ,int power)
        {
            Personality = personality;
            Name = name;
            CallingForHelp = callingForHelp;
            Power = power;
        }
        
        protected Person(string personality, string name, int power)
        {
            Personality = personality;
            Name = name;
            Power = power;
        }

        public virtual void Pull(Plant plant)
        {
            Console.Write($"I`m ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Name} ");
            Console.ResetColor();
            Console.Write($"and I pulls this ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName} ");
            Console.ResetColor();
            Console.Write($"off\n");
        }

        public virtual string CallForHelp()
        {
            return $"I can`t pull it out I need help!";
        }
    }
}
