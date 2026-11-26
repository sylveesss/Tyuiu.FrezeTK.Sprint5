using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FrezeTK.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = double.Parse(strX.Replace(',', '.'), CultureInfo.InvariantCulture);

            double res = (1.0 / Math.Cos(x)) + Math.Pow(x, 3);
            return Math.Round(res, 3);
        }
    }
}
