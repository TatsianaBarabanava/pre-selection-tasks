using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
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

