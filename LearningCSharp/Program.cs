using LearningCSharp;
using System;
using System.Runtime.ConstrainedExecution;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа с калькулятором
            Calculator calc = new Calculator();
            Console.WriteLine("Работа с калькулятором:");
            double num1 = 10;
            double num2 = 5;
            Console.WriteLine($"{num1} + {num2} = {calc.Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {calc.Subtract(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {calc.Multiply(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {calc.Divide(num1, num2)}");

            // Работа с машиной
            Car myCar = new Car();
            myCar.Make = "Москвич";
            myCar.Model = "УАЗ";
            myCar.Year = 2024;
            myCar.Color = "Зеленый";
            Console.WriteLine("\nИнформация о машине:");
            myCar.DisplayInfo();
        }
    }
}

