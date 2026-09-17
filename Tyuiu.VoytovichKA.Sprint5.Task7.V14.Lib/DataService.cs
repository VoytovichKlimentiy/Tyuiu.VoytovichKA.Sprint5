using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string outpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V14.txt");
            if (File.Exists(outpath)) File.Delete(outpath);

            string text = File.ReadAllText(path);
            char[] buffer = text.ToCharArray();

            for (int i = 0; i<buffer.Length; i++)
            {
                char c = buffer[i];
                if (c >= 'a' && c <= 'z') buffer[i] = char.ToUpper(c);
            }
            string res = new string(buffer);
            File.WriteAllText(outpath, res);
            return outpath;
        }
    }
}
