using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task1.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Произвести табулирование функции на диапазоне [-5; 5] с шагом 1.       *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutputFileTask1.txt                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = DataService.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл создан в папке: " + path);
            Console.WriteLine("\nТаблица значений:");

            string[] lines = File.ReadAllLines(path);
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($"f({x}) = {lines[count]}");
                count++;
            }

            Console.ReadKey();
        }
    }
}
