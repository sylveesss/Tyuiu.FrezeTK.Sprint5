using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint5.Task6.V24.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V24.txt");
            File.WriteAllText(path, "123 45678 test 987654 10000");

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V24.txt");
            File.WriteAllText(path, "12345");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
