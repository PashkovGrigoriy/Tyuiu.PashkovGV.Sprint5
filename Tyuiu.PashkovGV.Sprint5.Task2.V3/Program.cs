using Tyuiu.PashkovGV.Sprint5.Task2.V3.Lib;
namespace Tyuiu.PashkovGV.Sprint5.Task2.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[,]
            {
                { 5, 9, 1,},
                { 1, 3, 9,},
                { 1, 2, 2,}
            };
            string res = ds.SaveToFileTextData(mas2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}