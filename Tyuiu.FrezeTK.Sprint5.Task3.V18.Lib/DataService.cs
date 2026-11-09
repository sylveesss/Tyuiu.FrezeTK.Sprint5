using System;
using System.IO;
using System.Text;

namespace Tyuiu.FrezeTK.Sprint5.Task3.V18.Lib
{
    public class DataService
    {
        public static string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask3.bin");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
