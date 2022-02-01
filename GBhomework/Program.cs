using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBhomework
{
    class Program
    {
        static int Fibonacci(int num)
        {
            //0 1 1 и т.д
            int[] fibnum = new int[num];
            fibnum[0] = 0;
            fibnum[1] = 1;
            for(int i = 2; i < fibnum.Length; i++)
            {
                fibnum[i] = fibnum[i - 1] + fibnum[i - 2];
            }
            return fibnum[(num-1)];
        }
        static void Main(string[] args)
        {
            //(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
            Console.ReadKey();
        }
    }
}
