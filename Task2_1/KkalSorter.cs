using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_1
{
    public class KkalSorter : IComparer<Vegetable>
    {
        public int Compare(Vegetable x, Vegetable y)
        {
            if (x.Kkal > y.Kkal)
            {
                return 1;
            }
            else if (x.Kkal < y.Kkal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
