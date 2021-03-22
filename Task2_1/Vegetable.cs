using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Vegetable
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public double Kkal { get; set; }
        public double VegetableWeight { get; set; } //gramms
        public Vegetable() { }
        public Vegetable(string Category, string Name, double Kkal, double VegetableWeight)
        {
            this.Category = Category;
            this.Name = Name;
            this.Kkal = Kkal;
            this.VegetableWeight = VegetableWeight;
        }
    }
}
