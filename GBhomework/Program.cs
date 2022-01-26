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
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Введите минимальную температуру за сутки");
            float min = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            float max = float.Parse(Console.ReadLine());
            Console.WriteLine($"Средеяя температура за сутки: {(min + max)/2}");
            Console.ReadKey();

        }
    }
}
