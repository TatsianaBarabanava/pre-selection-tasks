using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
    public class Cucumber : FruitVegetables
    {
        public Cucumber()
        {
            Category = base.Category;
            Name = "Cucumber";
            Kkal = 15;
            VegetableWeight = 100;
        }
    }
}
