using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
        public class Car
        {
            // Свойства машины
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            // Метод для отображения информации о машине
            public void DisplayInfo()
            {
                Console.WriteLine("Информация о машине:");
                Console.WriteLine($"Марка: {Make}");
                Console.WriteLine($"Модель: {Model}");
                Console.WriteLine($"Год: {Year}");
                Console.WriteLine($"Цвет: {Color}");
            }
        }
 }
