using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task1.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextDataValid()
        {
            int start = -5;
            int stop = 5;
            string path = DataService.SaveToFileTextData(start, stop);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
