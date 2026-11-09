
using System;
using System.IO;

namespace Tyuiu.FrezeTK.Sprint5.Task5.V13.Lib
{
    public class DataService
    {
        public static double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    line = line.Replace('.', ',');
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numStr in numbers)
                    {
                        if (double.TryParse(numStr, out double num))
                        {
                            if (num >= -1.5 && num <= 1.5)
                            {
                                sum += num;
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0) return 0;

            return Math.Round(sum / count, 3);
        }
    }
}
