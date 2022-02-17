using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GBhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет
            //завершить указанный процесс.Предусмотреть возможность завершения процессов с помощью указания его ID 
            //или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

            //выводит на экран запущенные процессы
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID процесса: {process.Id}  \nИмя процесса: {process.ProcessFullName}\n");
            }

            //возможность завершения процессов
            Console.WriteLine("Вы можете завершить какой-нибудь процесс\nЧтобы завершить процесс, введите его имя или ID\n");
            string UserAnswer = Console.ReadLine();
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.Id.Equals(int.Parse(UserAnswer)))
                    {
                        process.Kill();
                    }
                }
                
            }
            catch
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName.Contains(UserAnswer)) {

                        process.Kill();
                    }
                }
            }
            finally
            {
                Console.WriteLine("\nПроцесс завершен в экстренном режиме\nХорошего дня");
            }

            Console.ReadKey();
            
        }
    }
}
