using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task3.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSavedDouble()
        {
            string path = ds.SaveToFileTextData(2);
            using BinaryReader reader = new BinaryReader(File.OpenRead(path));
            Assert.AreEqual(11.68, reader.ReadDouble());
        }
    }
}
