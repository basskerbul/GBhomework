using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBhomework
{
    class Program
    {
        static int Summ(string values) {

            string[] numbers = values.Split(' ');
            int result = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                result += int.Parse(numbers[i]);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
            //и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.

            string strnum = Console.ReadLine();
            Console.WriteLine(Summ(strnum));
            Console.ReadKey();
        }
    }
}
