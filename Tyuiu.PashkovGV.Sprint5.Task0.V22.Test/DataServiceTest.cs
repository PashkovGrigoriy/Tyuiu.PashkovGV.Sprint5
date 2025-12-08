using Tyuiu.PashkovGV.Sprint5.Task0.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string p = @"C:\Users\user\source\repos\Tyuiu.PashkovGV.Sprint5\Tyuiu.PashkovGV.Sprint5.Task0.V22\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool f = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, f);
        }
    }
}
