using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

