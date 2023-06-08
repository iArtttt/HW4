using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class GrandFather : Person
    {

        public GrandFather() : base("GrandFather", "Oleg", "Fine it`s too heavy, who need my money?!?!", 5) { }

        public override void Pull(Plant plant)
        {
            Console.Write($"I'm ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Name} ");
            Console.ResetColor();
            Console.Write($"and I'll take all money from this ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName}\n");
            Console.ResetColor();
        }
        public override string CallForHelp()
        {
            return CallingForHelp;
        }

    }
}
