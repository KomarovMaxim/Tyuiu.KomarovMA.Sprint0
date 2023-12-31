﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint0.Task7.Lib;
namespace Tyuiu.KomarovMA.Sprint0.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Комаров М.А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Комаров Максим Александрович | СМАРТб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая суммирует значения двух одиннаковых         *");
            Console.WriteLine("* массивов по длине.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива 1");
            foreach (int el in arrayNums1)
            {
                Console.WriteLine(el);
            }

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива 2");
            foreach (int el in arrayNums2)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int result = 0;
                int[] resultArr = DataService.AdditionArrays(arrayNums2, arrayNums1);
                foreach (int c in resultArr)
                {
                    result = result + c;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Длина массивов не равна");
            }


            Console.ReadKey();
        }
    }
}
