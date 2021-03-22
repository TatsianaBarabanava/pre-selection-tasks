using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task3
{
    [Serializable]
    public class Vegetable
    {
        //[XmlElement("Category")]
        public string Category { get; set; }
        //[XmlElement("Name")]
        public string Name { get; set; }
        //[XmlElement("Kkal")]
        public double Kkal { get; set; }
        //[XmlElement("VegetableWeight")]
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
