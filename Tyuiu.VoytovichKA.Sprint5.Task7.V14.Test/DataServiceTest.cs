using Tyuiu.VoytovichKA.Sprint5.Task7.V14.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string inpath = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask7V14.txt");
            ds.LoadDataAndSave(inpath);
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V14.txt");
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
