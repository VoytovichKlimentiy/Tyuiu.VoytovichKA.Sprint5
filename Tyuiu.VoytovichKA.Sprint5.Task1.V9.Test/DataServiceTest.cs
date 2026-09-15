using Tyuiu.VoytovichKA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = -5, b = 5;
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(a,b);
            bool fe = File.Exists(path);
            Assert.IsTrue(fe);
        }
    }
}
