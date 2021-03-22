using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class VegetativeVegetables : Vegetable
    {
        public VegetativeVegetables()
        {
            Category = "VegetativeVegetables";
            Name = this.Name;
            Kkal = this.Kkal;
            VegetableWeight = this.VegetableWeight;
        }
    }
}
