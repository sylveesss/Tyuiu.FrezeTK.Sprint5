using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все строчные латинские буквы на заглавные. Результат сохранить *");
            Console.WriteLine("* в файл OutputFileTask7V14.txt и вывести на экран.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V14.txt";
            Console.WriteLine("Путь к файлу: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Ошибка! Файл не найден по указанному пути.");
            }
            else
            {
                Console.WriteLine("Содержимое файла до обработки: \n" + File.ReadAllText(path));

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                string savePath = DataService.LoadDataAndSave(path);
                Console.WriteLine("Файл успешно сохранен в: " + savePath);
                Console.WriteLine("\nСодержимое файла после обработки: \n" + File.ReadAllText(savePath));
            }

            Console.ReadKey();
        }
    }
}
