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
            //Написать программу — телефонный справочник — создать двумерный массив 5*2,
            //хранящий список телефонных контактов: первый элемент хранит имя контакта,
            //второй — номер телефона/e-mail.  
            string[,] telDirA = {
                {"Oля", "Сережа", "Женя", "Саша", "Игорь" },
                {"655-269", "324-798", "115-356", "472-896", "412-632" }
            };
            string[,] telDirB = {
                {"Оля", "655-269", "Сережа", "324-798", "Женя" },
                {"115-356", "Саша", "472-896", "Игорь", "412-632" }
            };
        }
    }
}
