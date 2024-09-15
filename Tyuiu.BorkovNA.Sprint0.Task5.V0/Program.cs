using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Tyuiu.BorkovNA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B ="+DataServise.Addition(1, 5));
            Console.WriteLine("A - B =" + DataServise.Subtraction(15, 5));
            Console.WriteLine("A * B =" + DataServise.Multiplication(10, 10));
            Console.WriteLine("A / B =" + DataServise.Division(9, 3));
            Console.ReadKey();

        }
    }

}