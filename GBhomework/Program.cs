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
            //Написать программу, выводящую элементы двухмерного массива по диагонали.

            string[,] arr = { {"Написать", "программу", "выводящую", "элементы"}, {"двухмерного", "массива", "по", "диагонали"} };
            string indention = "";
            for (int i = 0; i < arr.GetLength(0); i++) {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"{indention}{arr[i, j]}");
                    indention += "      ";
                }
            }
            Console.ReadKey();
        }
    }
}
