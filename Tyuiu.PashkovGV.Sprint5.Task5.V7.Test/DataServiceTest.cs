using Tyuiu.PashkovGV.Sprint5.Task5.V7.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string p = @"D:\DataSprint5\InPutDataFileTask5V7.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool f = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, f);
        }
    }
}