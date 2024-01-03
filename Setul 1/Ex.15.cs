using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul c: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int t = a;
                a = b;
                b = t;
            }
            if (b > c) {
                int t = b;
                b = c;
                c = t;
            }
            if (a > b)
            {
                int t = a;
                a = b;
                b = t;
            }
            Console.WriteLine($"Numerele in ordinea crescatoare sunt: {a},{b},{c}");
        }

     
    }
}
