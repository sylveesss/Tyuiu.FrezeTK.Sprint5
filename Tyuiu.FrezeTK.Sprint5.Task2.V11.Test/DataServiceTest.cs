using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task2.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextDataValid()
        {
            int[,] matrix = new int[,] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };
            string path = DataService.SaveToFileTextData(matrix);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
