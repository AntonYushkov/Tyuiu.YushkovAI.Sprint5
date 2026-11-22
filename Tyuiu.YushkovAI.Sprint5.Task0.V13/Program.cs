using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task0.V13.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task0.V13
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
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = -1,4*x^3 + 2,3*x^2 + 0,6*x при x = 5.                  *");
            Console.WriteLine("* Округлить до трёх знаков, сохранить в OutPutFileTask0.txt               *");
            Console.WriteLine("* и вывести результат в консоль.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine($"Файл находится по пути: {path}");
        }
    }
}
