using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task2.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSavedMatrix()
        {
            int[,] matrix = { { -8, -1, -9 }, { 8, 5, 5 }, { 9, 6, -2 } };
            string path = ds.SaveToFileTextData(matrix);
            CollectionAssert.AreEqual(new[] { "0;0;0", "1;1;1", "1;1;0" }, File.ReadAllLines(path));
        }
    }
}
