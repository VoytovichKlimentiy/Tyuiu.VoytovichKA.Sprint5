using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0, res = 0;
            foreach (char c in text)
            {
                if (c == ' ') count++;
                else
                {
                    if (count >= 2) res++;
                    count = 0;
                }
            }
            return res;
        }
    }
}
