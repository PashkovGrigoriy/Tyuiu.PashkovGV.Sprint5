using Tyuiu.PashkovGV.Sprint5.Task3.V1.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}