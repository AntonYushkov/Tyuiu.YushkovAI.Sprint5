using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            string[] rows = new string[matrix.GetLength(0)];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] values = new string[matrix.GetLength(1)];
                for (int j = 0; j < values.Length; j++)
                {
                    values[j] = matrix[i, j] > 0 ? "1" : "0";
                }
                rows[i] = string.Join(";", values);
            }

            File.WriteAllLines(path, rows);
            return path;
        }
    }
}
