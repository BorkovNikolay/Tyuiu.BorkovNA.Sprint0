using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Tyuiu.BorkovNA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataServise.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataServise.SubtractionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataServise.MultArray(numsArray));
            Console.ReadKey();

        }
    }

}