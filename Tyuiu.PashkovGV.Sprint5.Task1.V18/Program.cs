using Tyuiu.PashkovGV.Sprint5.Task1.V18.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            string res = ds.SaveToFileTextData(x, y);
            Console.WriteLine(res);
        }
    }
}