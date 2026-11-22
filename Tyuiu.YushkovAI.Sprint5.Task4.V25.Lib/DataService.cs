using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = double.Parse(data, System.Globalization.CultureInfo.InvariantCulture);
            return Math.Round((Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x), 3);
        }
    }
}
