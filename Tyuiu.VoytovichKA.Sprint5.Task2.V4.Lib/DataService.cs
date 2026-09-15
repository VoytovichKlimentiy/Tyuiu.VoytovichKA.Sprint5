using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VoytovichKA.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows=matrix.GetLength(0);
            int columns=matrix.GetLength(1);
            string str = "", path = Path.GetTempFileName();
            if (File.Exists(path) == true) File.Delete(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= 0) matrix [i,j]=1;
                    else matrix[i,j]=0;
                    if (j != columns - 1) str += matrix[i, j] + ";";
                    else str += matrix[i, j];
                }
                if (i != rows - 1) File.AppendAllText(path, str + Environment.NewLine);
                else File.AppendAllText(path, str);
                str = "";
            }
            return path;
        }
    }
}
