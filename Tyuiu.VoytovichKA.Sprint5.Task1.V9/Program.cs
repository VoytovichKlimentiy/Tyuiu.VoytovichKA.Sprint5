using Tyuiu.VoytovichKA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести  в *");
            Console.WriteLine("* текстовый файл и вывести на консоль.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int a = -5, b = 5;
            Console.WriteLine("Старт шага = " + a);
            Console.WriteLine("Конец шага = " + b);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(a,b);
            Console.WriteLine("Файл: " + res + " создан.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}