using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task1.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = sin(x) + (cos(x)+1)/(2-x) + 2x на диапазоне [-5; 5] *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. Результат сохранить в   *");
            Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            string[] lines = File.ReadAllLines(res);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6}  |", startValue + i, lines[i]);
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
