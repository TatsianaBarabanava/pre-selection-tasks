using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NoItemsToSortException : Exception
    {
        public NoItemsToSortException()
        {
            Console.WriteLine("No items to sort! The salad is empty! \n");
        }
    }
}

