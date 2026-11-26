using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FrezeTK.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;
            int digitLength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digitLength++;
                }
                else
                {
                    if (digitLength == 5)
                    {
                        count++;
                    }
                    digitLength = 0;
                }
            }

            if (digitLength == 5)
            {
                count++;
            }

            return count;
        }
    }
}
