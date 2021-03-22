using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NoItemsToRemoveException : Exception
    {
        public NoItemsToRemoveException()
        {
            Console.WriteLine("No items to remove! \n");
        }
    }

}
