using Tyuiu.PashkovGV.Sprint5.Task4.V8.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string p = @"D:\DataSprint5\InPutDataFileTask4V8.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool f = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, f);
        }
    }
}