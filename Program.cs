// public partial class MainClass
//{
//  public double Add(double a, double b)
//  { 
//      return a + b; 
//  }
//  static void Main(string[] args)
//  {     
//      double a = 1;    
//      double b = 2;    
//      MainClass mainClass = new MainClass();    
//      double result = mainClass.Add(a, b);    
//      Console.WriteLine(result);
//  }

using System;
namespace MathOperations // Математические операции
{    class Program
    {
        static void Main(string[] args) // Метод запрашивает ввод двух чисел и операцию. Выполняет операцию и выводит результат.
        {
            double num1 = 0, num2 = 0;

            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: +, -, *, /");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Результат: {Add(num1, num2)}");
                    break;
                case '-':
                    Console.WriteLine($"Результат: {Subtract(num1, num2)}");
                    break;
                case '*':
                    Console.WriteLine($"Результат: {Multiply(num1, num2)}");
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine($"Результат: {Divide(num1, num2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    break;
            }
        }
        static double Add(double a, double b) // Сложение
        {
            return a + b;
        }
        static double Subtract(double a, double b) // Вычитание
        {
            return a - b;
        }
        static double Multiply(double a, double b) // Умножение
        {
            return a * b;
        }
        static double Divide(double a, double b) // Метод деления с проверкой деления на ноль. Если делитель равен нулю, выбрасывает исключение DivideByZeroException.
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return a / b;
        }
    }
}
