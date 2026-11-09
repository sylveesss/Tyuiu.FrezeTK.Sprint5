using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FrezeTK.Sprint5.Task6.V24.Lib;

namespace Tyuiu.FrezeTK.Sprint5.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V24.txt");
            File.WriteAllText(path, "12345 abc 67890 123 55555");

            int res = DataService.LoadFromDataFile(path);
            Assert.AreEqual(3, res); 
        }
    }
}
