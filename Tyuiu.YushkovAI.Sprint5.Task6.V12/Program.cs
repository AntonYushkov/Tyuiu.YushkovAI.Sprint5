using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task6.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task6.V12
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
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать текст из файла InPutDataFileTask6V12.txt.                     *");
            Console.WriteLine("* Найти количество удвоенных букв «нн» в тексте.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string path = Path.Combine(folder, "InPutDataFileTask6V12.txt");
            Console.WriteLine($"Входной файл: {path}");
            if (!File.Exists(path))
            {
                Console.WriteLine("Поместите входной файл из архива в указанную папку.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int count = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество пар «нн»: {count}");
        }
    }
}
