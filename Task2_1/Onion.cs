using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Onion : VegetativeVegetables
    {
        public Onion()
        {
            Category = this.Category;
            Name = "Onion";
            Kkal = 40;
            VegetableWeight = 10;
        }
    }
}
