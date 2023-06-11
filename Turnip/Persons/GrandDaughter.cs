using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class GrandDaughter : Person
    {
        public GrandDaughter() : base("Granddaughter", "Zinoida", "Ah, come to me darling.",3) { }

        public override void Pull(Plant plant)
        {
            Console.Write($"Why do I, the goddess ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Name} ");
            Console.ResetColor();
            Console.Write($"have to pull this ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{plant.PlantName}?!\n");
            Console.ResetColor();
        }
        public override string CallForHelp()
        {
            return CallingForHelp;
        }
    }
}
