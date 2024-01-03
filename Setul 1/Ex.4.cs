using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti anul: ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine("Anul este bisect.");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect.");
            }
        }
    }
}
