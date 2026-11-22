using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task1.V4.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулировать F(x) = cos(x)/(x+1) - 1,3*cos(x) + 3*x                     *");
            Console.WriteLine("* на [-5; 5] с шагом 1. При делении на ноль записать 0.                   *");
            Console.WriteLine("* Округлить до двух знаков. Сохранить в OutPutFileTask1.txt               *");
            Console.WriteLine("* и вывести значения в таблицу.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Диапазон: [{startValue}; {stopValue}], шаг 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            string[] values = File.ReadAllLines(path);
            Console.WriteLine("   x |    F(x)");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{startValue + i,4} | {double.Parse(values[i]),7:F2}");
            }
            Console.WriteLine($"Файл: {path}");
        }
    }
}
