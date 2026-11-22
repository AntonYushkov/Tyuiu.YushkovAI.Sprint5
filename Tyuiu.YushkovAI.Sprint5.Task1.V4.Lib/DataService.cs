using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            string[] results = new string[stopValue - startValue + 1];

            for (int i = 0; i < results.Length; i++)
            {
                int x = startValue + i;
                double cos = Math.Cos(x);
                double result = x == -1 ? 0 : cos / (x + 1.0) - 1.3 * cos + 3.0 * x;
                results[i] = Math.Round(result, 2).ToString();
            }

            File.WriteAllLines(path, results);
            return path;
        }
    }
}
