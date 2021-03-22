using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class InvalidKkalRangeException : Exception
    {
        public InvalidKkalRangeException()
        {
            Console.WriteLine("This kkal range is not valid! \n");
        }
    }

}
