using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.FrezeTK.Sprint5.Task6.V24.Lib
{
    public class DataService
    {
        public static int LoadFromDataFile(string path)
        {
            if (!File.Exists(path)) return 0;

            string text = File.ReadAllText(path);
            int count = 0;

            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length == 5 && int.TryParse(word, out _))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
