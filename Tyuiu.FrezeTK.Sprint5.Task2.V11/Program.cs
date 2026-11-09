using System;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task2.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0. Результат сохранить в файл    *");
            Console.WriteLine("* OutputFileTask2.csv и вывести на консоль.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[,] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = DataService.SaveToFileTextData(matrix);

            Console.WriteLine("Файл создан в папке: " + path);
            Console.WriteLine("\nРезультат из файла:");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line.Replace(";", "\t"));
            }

            Console.ReadKey();
        }
    }
}
