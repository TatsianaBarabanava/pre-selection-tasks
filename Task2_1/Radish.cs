using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Radish : VegetativeVegetables
    {
        public Radish()
        {
            Category = base.Category;
            Name = "Radish";
            Kkal = 16;
            VegetableWeight = 15;
        }
    }
}
