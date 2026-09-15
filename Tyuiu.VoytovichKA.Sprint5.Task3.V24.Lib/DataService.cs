using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            double y = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            y = Math.Round(y, 3);
            string path = Path.GetTempFileName();
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
