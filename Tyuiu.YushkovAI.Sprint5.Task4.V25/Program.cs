using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task4.V25.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task4.V25
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
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать вещественное число x из файла.                                *");
            Console.WriteLine("* Вычислить y = (x^4 + cos(x)) * sin(x).                                  *");
            Console.WriteLine("* Округлить до трёх знаков и вывести на консоль.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string path = Path.Combine(folder, "InPutDataFileTask4V25.txt");
            if (!File.Exists(path))
            {
                path = Path.Combine(folder, "InPutDataFileTask4V0.txt");
            }
            Console.WriteLine($"Файл: {path}");
            if (!File.Exists(path))
            {
                Console.WriteLine("Поместите входной файл из архива в указанную папку.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"y = {result}");
        }
    }
}
