using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovAI.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            string[] values = File.ReadAllText(path)
                .Split(new[] { ' ', '\t', '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int max = -1;

            foreach (string value in values)
            {
                string text = value.TrimEnd(',').Replace(',', '.');
                if (double.TryParse(text, System.Globalization.NumberStyles.Float,
                        System.Globalization.CultureInfo.InvariantCulture, out double number)
                    && number > max && number <= int.MaxValue && number % 3 == 0)
                {
                    max = (int)number;
                }
            }

            if (max < 0)
            {
                return 0;
            }

            double result = 1;
            for (int i = 2; i <= max && !double.IsInfinity(result); i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
