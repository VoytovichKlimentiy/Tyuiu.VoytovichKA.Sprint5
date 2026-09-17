using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            double x = Double.Parse(File.ReadAllText(path), CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Pow(Math.Pow(x, 2) / Math.Sin(x), 3),3);
            return res;
        }
    }
}
