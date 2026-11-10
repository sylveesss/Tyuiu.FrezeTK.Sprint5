using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib
{
    public class DataService: ISprint5Task7V14
    {
        public static string LoadDataAndSave(string path)
        {
            string savePath = Path.Combine(Path.GetTempPath(), "OutputFileTask7V14.txt");

            if (File.Exists(savePath))
            {
                File.Delete(savePath);
            }

            string text = File.ReadAllText(path);

            string resultText = Regex.Replace(text, "[a-z]", m => m.Value.ToUpper());

            File.WriteAllText(savePath, resultText);
            return savePath;
        }
    }
}
