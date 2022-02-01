using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBhomework
{
    class Program
    {
        static string GetFuiiName(string firstName, string lastName, string patronymic)
        {
            string fullName = $"{lastName} {firstName} {patronymic}";
            return fullName;
        }
        static void Main(string[] args)
        {
            //Написать метод GetFullName(string firstName, string lastName, string patronymic), 
            //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
            //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            Console.WriteLine(GetFuiiName("Мириам", "Петросян", "Сергеевна"));
            Console.WriteLine(GetFuiiName("Владимир", "Лебедев", "Иванович"));
            Console.WriteLine(GetFuiiName("Михаил", "Булгаков", "Афанасьевич"));

            Console.ReadKey();
        }
    }
}
