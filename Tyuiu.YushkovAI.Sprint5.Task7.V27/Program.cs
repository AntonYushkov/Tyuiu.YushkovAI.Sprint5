using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task7.V27.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task7.V27
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать символьные данные из файла. Удалить пробелы,                  *");
            Console.WriteLine("* идущие подряд больше одного. Сохранить результат                        *");
            Console.WriteLine("* в OutPutDataFileTask7V27.txt.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string path = Path.Combine(folder, "InPutDataFileTask7V27.txt");
            Console.WriteLine($"Входной файл: {path}");
            if (!File.Exists(path))
            {
                Console.WriteLine("Поместите входной файл из архива в указанную папку.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.LoadDataAndSave(path);
            Console.WriteLine("Текст после удаления групп пробелов:");
            Console.WriteLine(result);
        }
    }
}
