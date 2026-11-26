using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V14.txt в котором есть набор   *");
            Console.WriteLine("* символьных данных. Заменить все строчные латинские буквы на заглавные.  *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V14.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V14.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен в файл: " + pathSaveFile);
            Console.WriteLine("Содержимое файла:\n" + File.ReadAllText(pathSaveFile));

            Console.ReadKey();
        }
    }
}
