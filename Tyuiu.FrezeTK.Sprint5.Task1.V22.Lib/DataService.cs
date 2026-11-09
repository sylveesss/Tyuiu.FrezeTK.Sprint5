using System;
using System.IO;

namespace Tyuiu.FrezeTK.Sprint5.Task1.V22.Lib
{
    public class DataService
    {
        public static string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 - x;
                double y = 0;

                if (Math.Abs(denominator) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / denominator + 2 * x;
                    y = Math.Round(y, 2);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, y.ToString() + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, y.ToString());
                }
            }

            return path;
        }
    }
}
