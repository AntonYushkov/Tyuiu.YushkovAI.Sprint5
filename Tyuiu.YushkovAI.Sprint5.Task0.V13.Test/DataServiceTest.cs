using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task0.V13.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSavedResult()
        {
            string path = ds.SaveToFileTextData(5);
            Assert.AreEqual(-114.5, double.Parse(File.ReadAllText(path)));
        }
    }
}
