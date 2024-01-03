using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Introduceti primul numar: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Introduceti al doilea numar: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Introduceti al treileqa numar: ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("Introduceti al patrulea numar: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("Introduceti al cincilea numar: ");
                int e = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    int t = a;
                    a = b;
                    b = t;
                }
                if (a > c)
                {
                    int t = a;
                    a = c;
                    c = t;
                }
                if (a > d)
                {
                    int t = a;
                    a = d;
                    d = t;
                }
                if (a > e)
                {
                    int t = a;
                    a = e;
                    e = t;
                }
                if (b > c)
                {
                    int t = b;
                    b = c;
                    c = t;
                }
                 if (b > d)
                {
                  int t = b;
                  b = d;
                  d = t;
                 }
                 if (b > e)
                 {
                  int t = b;
                  b=e;
                  e = t;
                 }
                  if(c>d)
                  {
                    int t = c;
                    c = d;
                    d = t;
                  }
                    if (c > e)
                    {
                        int t = c;
                        c = e;
                        e = t;
                    }
                    if (d > e)
                    {
                        int t = d;
                        d = e;
                        e = t;
                    }
                    if(a>d)
                    {
                        int t = a;
                        a = d;
                        d = t;
                    }
                Console.WriteLine($"Numerele in ordinea crescatoare sunt: {a},{b},{c},{d},{e}");
                 }


        }
    }


