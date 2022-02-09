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
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            string path = @"C:\Users\REFRESH\Desktop\1.txt";
            string userText = Console.ReadLine();
            if(File.Exists(path) == false)
            {
                File.Create(path);
            }
            File.WriteAllText(path, userText);
            Console.ReadKey();
        }
    }
}
