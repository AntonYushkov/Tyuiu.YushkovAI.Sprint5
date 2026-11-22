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
                string result = ds.LoadDataAndSave(path);
                string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
                Assert.AreEqual("А Б В Г\nД Е", result);
                Assert.AreEqual(result, File.ReadAllText(outputPath));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
