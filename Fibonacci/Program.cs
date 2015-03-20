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
           if (range <=1)
           {
               return 1;
           }
            else
           {
               return NthFiboNumber(range - 1) + NthFiboNumber(range - 2);
           }
          
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
