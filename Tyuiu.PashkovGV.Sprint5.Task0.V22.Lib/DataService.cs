using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string p = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Pow((1 - x), 2) / (-3 * x);
            z = Math.Round(z, 3);
            File.WriteAllText(p, z.ToString() );
            return p;

        }
    }
}
