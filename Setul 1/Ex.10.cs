﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());

            if (EstePrim(numar))
            {
                Console.WriteLine($"{numar} este un numar prim.");
            }
            else
            {
                Console.WriteLine($"{numar} nu este un numar prim.");
            }
            Console.ReadLine();
        }
        static bool EstePrim(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n <= 3)
            {
                return true;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
