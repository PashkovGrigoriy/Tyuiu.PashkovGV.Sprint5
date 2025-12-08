using Tyuiu.PashkovGV.Sprint5.Task0.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine(res);
        }
    }
}