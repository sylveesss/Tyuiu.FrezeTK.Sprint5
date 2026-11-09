using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task3.V18.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextDataValid()
        {
            int x = 2;
            string path = DataService.SaveToFileTextData(x);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
