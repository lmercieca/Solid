using System;
using System.Collections.Generic;

namespace open_closed_before
{
    class Program
    {
        static void Main(string[] args)
        {
            var permitTypeOne = new PermitTypeOne() { Quantity = 100, Factor = 2 };
            var permitTypeTwo = new PermitTypeTwo() { Quantity = 200, Factor = 1 };

            var permits = new List<object>() { permitTypeOne, permitTypeTwo };
            
            var calculator = new PermitCostCalculator();

            Console.WriteLine(calculator.TotalCost(permits).ToString("C"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
