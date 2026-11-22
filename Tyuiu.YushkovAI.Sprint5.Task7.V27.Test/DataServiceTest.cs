using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint5.Task7.V27.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSavedText()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "А  Б В   Г\nД    Е");
                string outputPath = ds.LoadDataAndSave(path);
                Assert.AreEqual("А Б В Г\nД Е", File.ReadAllText(outputPath));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
