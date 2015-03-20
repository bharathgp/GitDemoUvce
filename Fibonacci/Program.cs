using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNFiboNumber(4);
        }

        public static int NthFiboNumber(int range)
        {
            int f1, f2, f;
            f1 = 1;
            f2 = 1;
            f = 1;
            if (range <= 1)
            {
                return f;
            }
            for (int i = 2; i <= range; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
            }
            return f;
          
        }

        public static void PrintNFiboNumber(int range)
        {
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine(NthFiboNumber(i));
            }
        }
    }
}
