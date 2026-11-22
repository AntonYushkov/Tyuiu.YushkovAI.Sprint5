using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task4.V25.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckValueFromFile()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "1");
                Assert.AreEqual(1.296, ds.LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
