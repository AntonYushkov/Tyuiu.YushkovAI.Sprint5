using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public static string GetOutputPath()
        {
            return Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
        }

        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                bool hasSpaceBefore = i > 0 && text[i - 1] == ' ';
                bool hasSpaceAfter = i + 1 < text.Length && text[i + 1] == ' ';
                if (text[i] == ' ' && (hasSpaceBefore || hasSpaceAfter))
                {
                    continue;
                }

                result.Append(text[i]);
            }

            string output = result.ToString();
            string outputPath = GetOutputPath();
            File.WriteAllText(outputPath, output);
            return output;
        }
    }
}
