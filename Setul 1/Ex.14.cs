using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m,o=0,p;
            Console.Write("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());
            m = n;
            while(n!=0)
            {
                p=n%10;
                o = o * 10 + p;
                n=n/10;
            }
            if (o == m)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }
        }
    }

}
