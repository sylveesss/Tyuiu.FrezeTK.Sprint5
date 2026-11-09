using System;
using System.IO;
using System.Globalization;

namespace Tyuiu.FrezeTK.Sprint5.Task4.V7.Lib
{
    public class DataService
    {
        public static double LoadFromDataFile(string path)
        {

            string strValue = File.ReadAllText(path).Trim();
            strValue = strValue.Replace('.', ',');

            double x = Convert.ToDouble(strValue);

            double y = (1.0 / Math.Cos(x)) + Math.Pow(x, 3);

            return Math.Round(y, 3);
        }
    }
}
