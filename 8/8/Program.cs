﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());
            int rezultat = Fibonacci(n);
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {rezultat}");
            Console.ReadLine();
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int a = 0, b = 1, c = 0;
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }

    }
}
