using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task3.V18.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения при x = 2, результат сохранить в бинарный  *");
            Console.WriteLine("* файл OutputFileTask3.bin и вывести на консоль. Округлить до 3 знаков.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = DataService.SaveToFileTextData(x);

            Console.WriteLine("Файл создан в папке: " + path);

            double value;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = reader.ReadDouble();
            }
            Console.WriteLine("Значение, считанное из бинарного файла: " + value);

            Console.ReadKey();
        }
    }
}
