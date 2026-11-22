using System.Text;
using Tyuiu.YushkovAI.Sprint5.Task3.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint5.Task3.V26
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
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = 0,7*x^3 + 1,52*x^2 при x = 2.                          *");
            Console.WriteLine("* Округлить до трёх знаков, сохранить в OutPutFileTask3.bin               *");
            Console.WriteLine("* и вывести результат в консоль.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);
            using BinaryReader reader = new BinaryReader(File.OpenRead(path));
            Console.WriteLine(reader.ReadDouble());
            Console.WriteLine($"Файл находится по пути: {path}");
        }
    }
}
