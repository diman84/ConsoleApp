using System;
using Dangl.Calculator;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет\n напиши формулу");
            var formula = Console.ReadLine();

            var calculation = Calculator.Calculate(formula);

            if (calculation.IsValid)
            {
                Console.WriteLine(calculation.Result);
            }
            else 
            {
                Console.WriteLine("Неверная формула");
            }
        }
    }
}
