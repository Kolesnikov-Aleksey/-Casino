using System;
using System.IO;

namespace Parsing
{
    public class Parsing
    {
        public static void Open()
        {
            string dirName = @"C:\Users\Геннадий\Desktop\ \ДВФУ\5 семестр\Методы програмирования\lesson_1-master\logs\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Введите название устройства");
            }
        }
    }
}
