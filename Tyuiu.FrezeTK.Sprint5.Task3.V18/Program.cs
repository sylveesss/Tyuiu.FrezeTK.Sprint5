using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task3.V18.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.12x^3 + 1.05x^2 + 4.1x * 2, вычислить его       *");
            Console.WriteLine("* значение при x = 2, результат сохранить в бинарный файл                 *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                double val = reader.ReadDouble();
                Console.WriteLine("Результат из файла: " + val);
            }

            Console.ReadKey();
        }
    }
}
