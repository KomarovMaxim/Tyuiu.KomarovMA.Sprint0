﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint0.Task5.Lib;
namespace Tyuiu.KomarovMA.Sprint0.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = " + DataService.Addition(1, 5));

            Console.WriteLine("a - b = " + DataService.Subtraction(15, 5));

            Console.WriteLine("a * b = " + DataService.Multiplication(10, 10));

            Console.WriteLine("a / b = " + DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
