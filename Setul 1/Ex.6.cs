using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lungimea primei laturi este: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Lungimea celei de-a doua latura este: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Lungimea celei de-a treia latura: ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Aceste numere pot fi lungimile laturilor unui triunghi.");
            }
            else
            {
                Console.WriteLine("Aceste numere nu pot fi lungimile laturilor unui triunghi.");
            }

        }
    }
}
