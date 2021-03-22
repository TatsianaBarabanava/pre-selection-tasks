using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Task1_2
{
    class Matrix
    {
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {

            int rows = a.GetLength(0);
            int size = b.GetLength(0);
            int cols = b.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int ret = 0;
                    for (int x = 0; x < size; x++)
                    {
                        ret += a[k, x] * b[x, j];
                    }
                    result[k, j] = ret;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {

            int[,] a = {
                {1, 2},
                {0, 1},
                {1, 0}};

            int[,] b = {
                {1 , 3, 5},
                {0, 7, 11}};

            Console.WriteLine("Result of Multiplication Matrixes a and b:" );
            Print(Multiplication(a, b));

            Console.ReadKey();
        }
    }
}









