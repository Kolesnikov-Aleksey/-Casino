using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lesson_1
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите путь к папке с логами");//C:\Users\Геннадий\source\repos\Lesson_1\logs
                string dirName = @Console.ReadLine();
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Введите название устройства");
                    string Name_devise = Console.ReadLine();
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string s in files)
                    {
                        Console.WriteLine(Parsing.Cut(s) + "\t" + Parsing.Open(s, Name_devise));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Папка не найдена, попробуйте снова");
                }
            }
            Console.ReadLine();
        }
    }
}
