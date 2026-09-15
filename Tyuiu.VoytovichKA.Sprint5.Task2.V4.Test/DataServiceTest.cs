using Tyuiu.VoytovichKA.Sprint5.Task2.V4.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[,] m = { { 5, -5, 6 }, { -5, 6, 7 }, { 7, 3, 5 } };
            string path = ds.SaveToFileTextData(m);
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
