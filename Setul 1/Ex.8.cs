using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea numarului a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea numarului b: ");
            int b = int.Parse(Console.ReadLine());
          if (a == b && b!=a)
            {
                a = b;
                b = a;
            }
            Console.WriteLine("Dupa inversare");
            Console.WriteLine("Valoarea numarului a este egal cu: " + b);
            Console.WriteLine("Valoarea numarului b este egal cu: " + a);
        }
    }
}
