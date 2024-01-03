using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            Console.Write("Introduceti numarul n:");
            int n=int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int ultimacifra = n % 10;
                k= k*10 + ultimacifra;
                n = n / 10;
                Console.WriteLine(k);
            }
           
            
        }
    }
}
