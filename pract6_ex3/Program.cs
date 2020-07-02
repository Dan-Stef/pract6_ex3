using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6_ex3
{
    class Program
    {
        static int[,] fillArray(out int n)
        {
            Console.WriteLine("Enter array(N x N) size: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void printArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static void Result(int[,] a)
        {
            int n = 0;
            int m = 0;
            if (a.GetLength(0) % 2 == 0)
            {
                n = (a.GetLength(0) / 2) - 1;
                m = (a.GetLength(0) / 2);           
            }
            else
            { m = a.GetLength(0) / 2;}
            for (int j = 0; j <= a.GetLength(0) - 1; j++)
            {
                int temp = a[n, j];
                a[n, j] = a[m, j];
                a[m, j] = temp;
            }
        }
        static void Main(string[] args)
        {
            int n;
            int[,] Array = fillArray(out n);
            Console.WriteLine("Source array:");
            printArray(Array);
            Console.WriteLine("Result array:");
            Result(Array);
            printArray(Array);
            Console.ReadKey();
        }
    }
}
