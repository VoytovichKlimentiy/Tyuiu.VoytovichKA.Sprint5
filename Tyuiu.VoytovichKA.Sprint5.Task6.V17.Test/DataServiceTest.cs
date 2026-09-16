using Tyuiu.VoytovichKA.Sprint5.Task6.V17.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask6V17.txt");
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void IsExisting()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask6V17.txt");
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
