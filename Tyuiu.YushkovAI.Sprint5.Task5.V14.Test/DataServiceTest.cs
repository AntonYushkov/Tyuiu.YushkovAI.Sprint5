using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task5.V14.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckLargestMultipleOfThree()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "6 11 3,5\n9 -3 7");
                Assert.AreEqual(362880.0, ds.LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
