using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int d = 2, p;

            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p != 0)
                {
                    Console.Write($"{d}^{p} *  ");
                
                }
                d++;

                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
        }
    }
}
