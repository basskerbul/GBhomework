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
            //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете 
            //и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных
            //(это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее 
            //заготовлены до вывода на консоль.
            string shop = "ООО 'МОЯ ОБОРОНА'";
            string seller = "Димооон";
            int saleNumber = 177;
            byte change = 7;

            string item1 = "iPhone 99 Pro Max Black 128Kb";
            string item2 = "Охота Крепкое 0%";

            decimal cost1 = 105999;
            decimal cost2 = 99;

            DateTime date = new DateTime(2025, 6, 30, 15, 55, 28);

            Console.WriteLine($"    __{shop}__\n        КАССОВЫЙ ЧЕК    \nПРИХОД\n           {seller}       \nПродажа №{saleNumber}       Смена №{change}");
            Console.WriteLine($"*********************************\n{item1}\n     {cost1}  x  1  =  {cost1}\n{item2}\n     {cost2}  x  1  =  {cost2}\nИТОГ                ={cost1 + cost2}\nБЕЗНАЛИЧНЫМИ        ={cost1 + cost2}\n**********************************");
            Console.WriteLine($"{shop}\nЛенинградская область, р-н \nПриморский, за соседними гаражами\n8(800)555 35 35\nКассир: {seller}\n{date}\n      ДОБРО ПОЖАЛОВАТЬ\n        уходите прочь");
            Console.ReadKey();


        }
    }
}
