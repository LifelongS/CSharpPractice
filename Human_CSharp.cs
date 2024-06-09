using System;
namespace HumanExample
{
    class Human
    {
        // Данные человека
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        // Ввод данных с консоли
        public void InputData()
        {
            Console.WriteLine("Введите имя:");
            FirstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            LastName = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        // Вывод данных
        public void DisplayData()
        {
            Console.WriteLine("Информация о человеке:");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Возраст: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            
            // Ввод данных с консоли
            person.InputData();

            // Вывод данных
            person.DisplayData();
        }
    }
}
