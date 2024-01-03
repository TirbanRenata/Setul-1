using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex.5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            string n = Console.ReadLine();
            Console.Write("Introduceti pozitia k: ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 0 && k <= n.Length)
            {
                char cif = n[n.Length - k];
                Console.WriteLine(cif);
            }
            else
            {
                Console.WriteLine("Valoarea lui k nu exista.");
                Console.WriteLine(k);
            }
        }
    }
}
