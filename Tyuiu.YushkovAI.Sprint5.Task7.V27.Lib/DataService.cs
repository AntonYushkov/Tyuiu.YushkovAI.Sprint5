using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
            File.WriteAllText(outputPath, text);
            return text;
        }
    }
}
