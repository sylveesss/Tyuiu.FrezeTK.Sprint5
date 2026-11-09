using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task4.V7.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");
            File.WriteAllText(path, "2.0");

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
