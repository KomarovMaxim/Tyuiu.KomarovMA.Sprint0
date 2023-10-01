using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint0.Task4.Lib;
namespace Tyuiu.KomarovMA.Sprint0.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 5));



            Console.WriteLine(DataService.Substraction(5, 5));



            Console.WriteLine(DataService.Multiplication(5, 5));



            Console.WriteLine(DataService.Divison(5, 5));
            Console.ReadKey();
        }
    }
}
