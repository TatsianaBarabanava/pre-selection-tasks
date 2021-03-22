using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
    public class FruitVegetables : Vegetable
    {
        public FruitVegetables()
        {
            Category = "FruitVegetables";
            Name = base.Name;
            Kkal = base.Kkal;
            VegetableWeight = base.VegetableWeight;
        }
    }
}
