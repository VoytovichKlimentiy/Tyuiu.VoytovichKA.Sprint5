using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string stY, path = Path.GetTempFileName();
            if (File.Exists(path) == true) File.Delete(path);
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x;
                if (double.IsNaN(y)) y = 0;
                y = Math.Round(y, 3);
                stY=y.ToString();
                if (x != stopValue) File.AppendAllText(path, stY + Environment.NewLine);
                else File.AppendAllText(path, stY);
            }    
            return path;
        }
    }
}
