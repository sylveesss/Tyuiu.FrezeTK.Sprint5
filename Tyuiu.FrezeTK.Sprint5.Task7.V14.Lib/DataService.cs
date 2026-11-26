using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V14.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path);
            StringBuilder sb = new StringBuilder(text.Length);

            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                {
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append(c);
                }
            }

            File.WriteAllText(pathSaveFile, sb.ToString());

            return pathSaveFile;
        }
    }
}
