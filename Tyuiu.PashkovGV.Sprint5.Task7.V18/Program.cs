using Tyuiu.PashkovGV.Sprint5.Task7.V18.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string a = @"D:\DataSprint5";
            string b = "InPutDataFileTask7V18.txt";

            string f = Path.Combine(a, b);

            string g = ds.LoadDataAndSave(f);
            File.WriteAllText(f, g);
            Console.ReadKey();
        }
    }
}