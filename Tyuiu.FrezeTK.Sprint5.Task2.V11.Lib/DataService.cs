using System;
using System.IO;

namespace Tyuiu.FrezeTK.Sprint5.Task2.V11.Lib
{
    public class DataService
    {
        public static string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask2.csv");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < columns; j++)
                {
                    int value = matrix[i, j];
                    if (value % 2 != 0)
                    {
                        value = 0;
                    }

                    line += value.ToString();
                    if (j < columns - 1)
                    {
                        line += ";";
                    }
                }

                if (i < rows - 1)
                {
                    File.AppendAllText(path, line + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, line);
                }
            }

            return path;
        }
    }
}
