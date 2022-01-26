using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            number = number % 2;
            if (number == 0)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число не четное");

            Console.ReadKey();
           
    }
}
}
