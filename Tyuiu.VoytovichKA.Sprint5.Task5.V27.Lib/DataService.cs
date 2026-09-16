using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VoytovichKA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            int count = 0;
            double res = 0;
            foreach (string str in strings)
            {
                if (double.TryParse(str.Trim(), CultureInfo.InvariantCulture, out double number) && number % 5 == 0)
                {
                    res += number;
                    count++;
                }
            }
            res =Math.Round(res/count,3);
            return res;
        }
    }
}
