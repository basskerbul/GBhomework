using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GBhomework
{
    class Program { 
    
        static void Main(string[] args)
        {
            //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

            string path = @"C:\";
            string PathForTextFile = @"C:\Users\REFRESH\Desktop\DirectoryTree.txt";

            string[] Dirs = Directory.GetDirectories(path);
            string[] Files = Directory.GetFiles(path);

            File.AppendAllText(PathForTextFile, $"Папки по пути {path}\n");
            File.AppendAllLines(PathForTextFile, Dirs);

            for(int i = 0; i < Dirs.Length; i++)
            {
                DirectoryInfo newDir = new DirectoryInfo(Dirs[i]);
                path = newDir.FullName;
                string[] SubDirs = Directory.GetDirectories(path);
                string[] SubFiles = Directory.GetFiles(path);
                File.AppendAllLines(PathForTextFile, SubFiles);
                File.AppendAllLines(PathForTextFile, SubDirs);
            }

            File.AppendAllText(PathForTextFile, "Файлы:\n");
            File.AppendAllLines(PathForTextFile, Files);
        }
    }
}
