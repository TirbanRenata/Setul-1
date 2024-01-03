using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul: ");
            int n=int.Parse(Console.ReadLine());
            int nr = 0;
            string strN=n.ToString();
            for(int i = 0; i < strN.Length; i++)
            {
                for(int j = i+1;j<strN.Length; j++)
                    if (strN[i] == strN[j])
                    {
                        nr++;
                        break;
                    }
            }
            if (nr >= 2)
                Console.WriteLine("Numarul este format doar cu doua cifre care se pot repeta");
            else
                Console.WriteLine("Numarul nu este format doar cu doua cifre care se pot repeta");
        }
    }
}
