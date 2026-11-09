using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task5.V13.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти среднее значение всех чисел в файле, которые находятся            *");
            Console.WriteLine("* в промежутке от -1.5 до 1.5. Округлить до трёх знаков.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V13.txt";
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

                double res = DataService.LoadFromDataFile(path);
                Console.WriteLine("Среднее значение чисел от -1.5 до 1.5 = " + res);
            }

            Console.ReadKey();
        }
    }
}
