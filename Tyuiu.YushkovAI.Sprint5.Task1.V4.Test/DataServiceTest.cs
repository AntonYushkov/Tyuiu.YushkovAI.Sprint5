using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task1.V4.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSavedValues()
        {
            string path = ds.SaveToFileTextData(-1, 1);
            string[] lines = File.ReadAllLines(path);
            double[] values = Array.ConvertAll(lines, double.Parse);
            CollectionAssert.AreEqual(new double[] { 0, -0.3, 2.57 }, values);
        }
    }
}
