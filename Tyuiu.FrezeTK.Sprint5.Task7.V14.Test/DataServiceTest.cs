using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSaveValid()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V14.txt");
            File.WriteAllText(path, "Привет abc мир XYZ");

            string savePath = DataService.LoadDataAndSave(path);
            bool fileExists = File.Exists(savePath);

            Assert.AreEqual(true, fileExists);
        }
    }
}
