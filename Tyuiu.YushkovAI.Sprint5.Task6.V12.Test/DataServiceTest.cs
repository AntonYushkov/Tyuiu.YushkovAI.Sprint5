using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task6.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckDoubleLetters()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "ванна, сон, длинный\nранний");
                Assert.AreEqual(3, ds.LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
