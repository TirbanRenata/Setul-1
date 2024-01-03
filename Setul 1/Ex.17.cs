using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul număr: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea număr: ");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = CalculateGCD(num1, num2);
            int lcm = (num1 * num2) / gcd;

            Console.WriteLine($"Cel mai mare divizor comun (CMMD) al celor două numere este: {gcd}");
            Console.WriteLine($"Cel mai mic multiplu comun (CMM) al celor două numere este: {lcm}");
            Console.ReadLine();
        }
        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
    
}
