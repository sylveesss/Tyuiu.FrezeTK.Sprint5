using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V14.txt");
            File.WriteAllText(path, "Hello мир! abc XYZ 123");

            DataService ds = new DataService();
            string pathSaveFile = ds.LoadDataAndSave(path);

            string res = File.ReadAllText(pathSaveFile);
            string wait = "HELLO мир! ABC XYZ 123";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V14.txt");
            File.WriteAllText(path, "test");

            DataService ds = new DataService();
            string pathSaveFile = ds.LoadDataAndSave(path);

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
