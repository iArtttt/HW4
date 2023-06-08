using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class GrandMother : Person
    {
        public GrandMother() : base("Grandmother", "Tamara", "I can`t pull it out I`m too young! I need help!", 4) { }

        public override string CallForHelp()
        {
            return CallingForHelp;
        }
    }
}
