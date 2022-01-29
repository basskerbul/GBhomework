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
            //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
            string input = Console.ReadLine();
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
