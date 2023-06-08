using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class Dog : Person
    {
        public Dog() : base("Dog", "Juchka", "Woooof!!!" , 3) { }
        public override string CallForHelp()
        {
            return CallingForHelp;
        }
    }
}
