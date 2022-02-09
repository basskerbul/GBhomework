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
            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            
            string path = @"C:\Users\REFRESH\Desktop\startup.txt";
            DateTime RightNow = DateTime.Now;
            string[] content = { $"{RightNow:U}" } ;
            Console.WriteLine(content);
            File.AppendAllLines(path, content);
            Console.ReadKey();


        }
    }
}
