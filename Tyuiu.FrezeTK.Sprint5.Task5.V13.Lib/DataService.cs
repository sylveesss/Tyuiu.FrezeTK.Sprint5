using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FrezeTK.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string part in parts)
            {
                double num = double.Parse(part.Replace(',', '.'), CultureInfo.InvariantCulture);
                if (num >= -1.5 && num <= 1.5)
                {
                    sum += num;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            double res = sum / count;
            return Math.Round(res, 3);
        }
    }
}
