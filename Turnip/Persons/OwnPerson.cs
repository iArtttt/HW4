﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip.Persons
{
    internal class OwnPerson : Person
    {
        public OwnPerson(string personality = "Owl", string name = "Sovunya", int power = 1) :base(personality, name, power)
        {
            
        }
    }
}
