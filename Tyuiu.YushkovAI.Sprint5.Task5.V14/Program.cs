using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task5.V14.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task5.V14
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
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать набор значений из файла. Найти наибольшее целое               *");
            Console.WriteLine("* число, кратное 3, вычислить его факториал и вывести.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string path = Path.Combine(folder, "InPutDataFileTask5V14.txt");
            Console.WriteLine($"Входной файл: {path}");
            if (!File.Exists(path))
            {
                Console.WriteLine("Поместите входной файл из архива в указанную папку.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Факториал = {result}");
        }
    }
}
