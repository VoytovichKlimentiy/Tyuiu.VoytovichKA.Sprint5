using Tyuiu.VoytovichKA.Sprint5.Task5.V27.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask5V27.txt");
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(5, res);
        }
    }
}
