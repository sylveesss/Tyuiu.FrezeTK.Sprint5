using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task6.V24.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество пятизначных чисел в заданной строке файла.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";
            Console.WriteLine("Путь к файлу: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Ошибка! Файл не найден по указанному пути.");
            }
            else
            {
                Console.WriteLine("Содержимое файла: " + File.ReadAllText(path));

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                int res = DataService.LoadFromDataFile(path);
                Console.WriteLine("Количество пятизначных чисел = " + res);
            }

            Console.ReadKey();
        }
    }
}
