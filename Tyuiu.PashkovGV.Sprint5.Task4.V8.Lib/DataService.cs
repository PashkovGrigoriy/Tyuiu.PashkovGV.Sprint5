using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string k = path;


            double z = double.Parse(path, CultureInfo.InvariantCulture);
            double i = Math.Round((((Math.Pow(z, 2)) / (Math.Sin(z))) + 3),3);
            return i;
        }
    }
}
