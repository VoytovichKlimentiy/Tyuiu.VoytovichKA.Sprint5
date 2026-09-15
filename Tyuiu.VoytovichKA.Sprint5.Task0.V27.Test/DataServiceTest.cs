using Tyuiu.VoytovichKA.Sprint5.Task0.V27.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            int x = 3;
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
