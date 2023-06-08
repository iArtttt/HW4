using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class Mouse : Person
    {
        public Mouse() : base("Mouse", "Mozgushka", "Is there anybody smarter than me?", 20) { }
        public override void Pull(Plant plant)
        {
            Console.WriteLine($"Why did no one except me take a shovel?");
        }
        public override string CallForHelp()
        {
            return CallingForHelp;
        }
    }
}
