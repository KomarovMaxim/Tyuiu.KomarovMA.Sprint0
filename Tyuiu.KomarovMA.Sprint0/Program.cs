using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint0.Task2.Lib;
namespace Tyuiu.KomarovMA.Sprint0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Максим"));
            Console.ReadKey();
        }
    }
}
