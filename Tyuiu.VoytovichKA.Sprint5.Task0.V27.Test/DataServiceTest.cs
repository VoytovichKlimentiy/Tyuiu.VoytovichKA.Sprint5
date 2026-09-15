using Tyuiu.VoytovichKA.Sprint5.Task0.V27.Lib;

namespace Tyuiu.VoytovichKA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            string path = @"E:\tyuiu\source\repos\Tyuiu.VoytovichKA.Sprint5\Tyuiu.VoytovichKA.Sprint5.Task0.V27\bin\Debug\net8.0\OutPutFileTask0.txt";
            bool ex = true;
            FileInfo fi=new FileInfo(path);
            bool fe = fi.Exists;
            DataService ds = new DataService();
            Assert.AreEqual(ex, fe);
        }
    }
}
