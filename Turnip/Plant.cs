using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnip
{
    internal class Plant
    {
        public string PlantName { get; private set; } = "Turnip";
        public int Weight { get; private set; } = 20;
        public Plant()
        {
        }
        public Plant(string plantName = "Turnip", int weight = 20)
        {
            PlantName = plantName;
            Weight = weight;            
        }
    }
}
