using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Tyuiu.BorkovNA.Sprint0.Task2.V0.Lib;


namespace Tyuiu.BorkovNA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Николай"));
            Console.ReadKey();

        }
    }

}