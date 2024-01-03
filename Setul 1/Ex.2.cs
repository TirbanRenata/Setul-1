using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduceti numarul a: ");
            double a= Double.Parse(Console.ReadLine()); 
            Console.Write("Introduceti numarul b: ");
            double b= Double.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul c: ");
            double c= Double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;

            if (delta > 0) {
                double x1=((-b+Math.Sqrt(delta))/(2*a));
                Console.WriteLine(x1);
                double x2=((-b-Math.Sqrt(delta))/(2*a));
                Console.WriteLine(x2);
            }
            if (delta == 0) {
                Console.WriteLine("Exista o singura solutie reala.");
               double x= -b / 2*a;
                Console.WriteLine(x);
                    }
            if(delta < 0)
            {
                Console.Write("Nu exista solutii reale.");
            }
             
        }
    }
}
