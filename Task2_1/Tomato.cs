﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Tomato : FruitVegetables
    {
        public Tomato()
        {
            Category = base.Category;
            Name = "Tomato";
            Kkal = 24;
            VegetableWeight = 50;
        }
    }
}
