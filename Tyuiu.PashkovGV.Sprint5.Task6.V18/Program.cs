using Tyuiu.PashkovGV.Sprint5.Task6.V18.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask6V18.txt";

            string f = Path.Combine(a, b);

            double g = ds.LoadFromDataFile(f);
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}