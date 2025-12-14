using Tyuiu.PashkovGV.Sprint5.Task5.V7.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask5V7.txt";

            string f = Path.Combine(a, b);

            double g = ds.LoadFromDataFile(f);
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}