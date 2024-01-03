using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Numarul x este egal cu: ");
            x = -b / a;
            Console.WriteLine(x);
            

        }
    }
}
