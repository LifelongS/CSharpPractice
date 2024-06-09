using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Calculator
    {
        // Метод для сложения
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Метод для вычитания
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Метод для умножения
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Метод для деления
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                return double.NaN;
            }
            return a / b;
        }
    }
}

