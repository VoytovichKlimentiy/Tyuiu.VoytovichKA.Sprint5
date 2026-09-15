using Tyuiu.VoytovichKA.Sprint5.Task6.V17.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Найти количество      *");
            Console.WriteLine("* пробелов, идущих подряд больше одного, в заданной строке.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask6V17.txt");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}