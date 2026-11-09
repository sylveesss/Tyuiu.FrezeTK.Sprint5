using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task0.V27.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения при x = 3, сохранить в текстовый файл      *");
            Console.WriteLine("* OutputFileTask0.txt и вывести на консоль. Округлить до 3 знаков.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = DataService.SaveToFileTextData(x);

            Console.WriteLine("Файл создан в папке: " + path);
            Console.WriteLine("Значение внутри файла: " + File.ReadAllText(path));

            Console.ReadKey();
        }
    }
}
