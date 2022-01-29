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
            //* «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
            //где Х — элементы кораблей, а О — свободные клетки.

            string[][] filed1 = new string[10][];
            filed1[0] = new string[]{ "O", "X", "X", "X", "O", "O", "O", "O", "X", "O" };
            filed1[1] = new string[] { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            filed1[2] = new string[] { "O", "O", "O", "X", "O", "O", "X", "X", "O", "O" };
            filed1[3] = new string[] { "O", "O", "O", "X", "O", "O", "O", "O", "O", "O" };
            filed1[4] = new string[] { "O", "O", "O", "X", "O", "O", "O", "X", "O", "O" };
            filed1[5] = new string[] { "O", "O", "O", "X", "O", "O", "O", "O", "O", "O" };
            filed1[6] = new string[] { "X", "X", "O", "O", "O", "X", "X", "X", "O", "O" };
            filed1[7] = new string[] { "O", "O", "O", "X", "O", "O", "O", "O", "O", "O" };
            filed1[8] = new string[] { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            filed1[9] = new string[] { "O", "X", "O", "O", "O", "O", "X", "X", "O", "O" };

            for (int j = 0; j < 10; j++)
            {

                foreach (string i in filed1[j])
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
