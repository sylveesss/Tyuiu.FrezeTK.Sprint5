using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task5.V13.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V13.txt");
            File.WriteAllText(path, "-2.0 -1.0 0.0 1.0 2.0");

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
