using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int Fibonacci(int k, int i, int togo)
        {
            while (i <= togo)
            {
                Console.WriteLine(k + ",");
                Console.WriteLine(i + ",");
                k = i + k;
                i = i + k;
                return Fibonacci(k, i, 64);

            }
            return 0;
            
        }
        static void Main(string[] args)
        {
            int j = 1;
            j = Fibonacci(0, j, 64);
            Console.WriteLine("**************************");
            var k = 0;
            for (int i = 1; i <= 64; i = i + k)
            {
                Console.WriteLine("k: " + k + " ,");
                Console.WriteLine("i: " + i + " ,");
                k = i + k;

            }

            Console.ReadKey();
        }

    }
}
