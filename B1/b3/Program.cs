﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("nhap c: ");
            float c = float.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("{0}, {1}, {2} là 3 canh cua 1 tam giac", a, b, c);
                
            }
            else
                Console.WriteLine("{0}, {1}, {2} khong phai là 3 canh cua 1 tam giac", a, b, c);
            
            Console.ReadKey();
        }
    }
}
