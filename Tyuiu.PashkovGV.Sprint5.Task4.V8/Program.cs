using Tyuiu.PashkovGV.Sprint5.Task4.V8.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask4V8.txt";

            string f = Path.Combine(a, b);
            string c = File.ReadAllText(f);
            double g = ds.LoadFromDataFile(c);
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}