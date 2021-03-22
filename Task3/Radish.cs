using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task3
{
    [Serializable]
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

