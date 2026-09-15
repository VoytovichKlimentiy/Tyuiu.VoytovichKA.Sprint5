using Tyuiu.VoytovichKA.Sprint5.Task7.V11.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string inpath = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask7V11.txt");
            ds.LoadDataAndSave(inpath);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutDataFileTask7V11.txt");
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
