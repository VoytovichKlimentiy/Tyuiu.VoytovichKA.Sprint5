using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string outpath=Path.Combine(Directory.GetCurrentDirectory(), "OutPutDataFileTask7V11.txt");
            if (File.Exists(outpath)) File.Delete(outpath);

            string text = File.ReadAllText(path), res="";

            foreach (char c in text)
            {
                if (!((c>='а' && c <= 'я') || c==' ' || c=='ё')) res += c;
            }
            File.WriteAllText(outpath, res);
            return outpath;
        }
    }
}
