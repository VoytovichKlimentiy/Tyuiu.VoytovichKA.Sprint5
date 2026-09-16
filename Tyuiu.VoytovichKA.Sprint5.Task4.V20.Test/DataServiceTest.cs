using Tyuiu.VoytovichKA.Sprint5.Task4.V20.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask4V20.txt");
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(-13784.56, res);
        }
    }
}
