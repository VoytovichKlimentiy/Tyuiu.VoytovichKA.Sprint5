using Tyuiu.VoytovichKA.Sprint5.Task7.V14.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все строчные *");
            Console.WriteLine("* латинские буквы на заглавные. Полученный результат сохранить в файл.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask7V14.txt");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string outpath = ds.LoadDataAndSave(path);
            Console.WriteLine("Файл: " + outpath + " создан.");
            Console.ReadLine();
        }
    }
}