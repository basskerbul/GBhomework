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
            //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, 
            //    вывести сообщение «Дождливая зима».
            Console.WriteLine("Введите минимальную температуру за сутки");
            float min = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            float max = float.Parse(Console.ReadLine());
            float temp = (min + max) / 2;

            Console.WriteLine($"Средеяя температура за сутки: {temp}");

            Console.WriteLine("Введите порядковый номер месяца");
            byte number = byte.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Январь");
                    if (temp > 0)
                        Console.WriteLine("Дождливая зама");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    if (temp > 0)
                        Console.WriteLine("Дождливая зама");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    if (temp > 0)
                        Console.WriteLine("Дождливая зама");
                    break;
                default:
                    Console.WriteLine("Месяца с таким порядковым номером нет :(");
                    break;
            }
            Console.ReadKey();

            
        }
    }
}
