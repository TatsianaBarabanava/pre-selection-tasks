using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class EmptySaladException : Exception
    {
		public EmptySaladException()
        {
            Console.WriteLine("Cannot fulfill the action! The salad is empty! \n");
        }
    }
}

