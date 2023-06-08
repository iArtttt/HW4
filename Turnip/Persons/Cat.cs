using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class Cat : Person
    {
        public Cat() : base("Cat","Marusya", "Meeeeeew!!!", 2) { }

        public override void Pull(Plant plant)
        {
            Console.Write($"I`ll spend one of my life but pulls ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName} ");
            Console.ResetColor();
            Console.Write($"out!\n");
        }
        public override string CallForHelp()
        {
            return CallingForHelp;
        }
    }
}
