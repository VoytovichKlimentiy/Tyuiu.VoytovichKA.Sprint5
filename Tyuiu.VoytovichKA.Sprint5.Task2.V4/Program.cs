using Tyuiu.VoytovichKA.Sprint5.Task2.V4.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан целочисленный массив 3 на 3 элементов, заполненный значениями с     *");
            Console.WriteLine("* клавиатуры. Заменить положительные элементы массива на 1, отрицательные *");
            Console.WriteLine("* на 0. Результат сохранить в файл и вывести в консоль.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("Массив: ");
            int[,] arr = { { 5, -5, 6 }, { -5, 6, 7 }, { 7, 3, 5 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ";\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(arr);
            Console.WriteLine("Файл: " + res + " создан.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}