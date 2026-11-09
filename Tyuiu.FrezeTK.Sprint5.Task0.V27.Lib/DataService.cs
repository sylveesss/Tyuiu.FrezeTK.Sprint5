
using System;
using System.IO;

namespace Tyuiu.FrezeTK.Sprint5.Task0.V27.Lib
{
    public class DataService
    {
        public static string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask0.txt");

            double y = Math.Pow(x - 1, 3 * x + 1);
            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
