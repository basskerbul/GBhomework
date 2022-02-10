using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GBhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            string path = @"C:\Users\REFRESH\Desktop\ByteFile.txt";
            string UserNumbers = Console.ReadLine();
            string[] userNumbers = UserNumbers.Split(' ');
            byte[] SetNumbers = new byte[userNumbers.Length];

            for (int i = 0; i < userNumbers.Length; i++)
            {
                SetNumbers[i] = Convert.ToByte(userNumbers[i]);
            }

            File.WriteAllBytes(path, SetNumbers);
        }
    }
}
