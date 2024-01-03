using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul n: ");
                int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numărului sunt: ");
            for ( int i=0; i<=n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i) ;
                }
            }
        }
    }
}
