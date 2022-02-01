using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBhomework
{
    class Program
    {
        enum timeOfYear: byte
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Distributior(int number)
        {
            if (number == 12 | number == 1 | number == 2)
                Console.WriteLine(timeOfYear.Winter);

            else if (number == 3 | number == 4 | number == 5)
                Console.WriteLine(timeOfYear.Spring);

            else if (number == 6 | number == 7 | number == 8)
                Console.WriteLine(timeOfYear.Summer);

            else if (number == 9 | number == 10 | number == 11)
                Console.WriteLine(timeOfYear.Autumn);
            else 
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            

        }

        static void Main(string[] args)
        {
            //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
            //На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, 
            //принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, 
            //лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
            //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

            byte userNumber = byte.Parse(Console.ReadLine());
            Distributior(userNumber);
            Console.ReadKey();
        }
    }
}
