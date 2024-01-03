using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul k: ");
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}");
                Console.ReadLine();
            }
        }
    }
}
