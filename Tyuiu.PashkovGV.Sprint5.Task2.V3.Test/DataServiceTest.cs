using Tyuiu.PashkovGV.Sprint5.Task2.V3.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            DataService ds = new DataService();
            string p = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool f = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, f);
        }
    }
}
