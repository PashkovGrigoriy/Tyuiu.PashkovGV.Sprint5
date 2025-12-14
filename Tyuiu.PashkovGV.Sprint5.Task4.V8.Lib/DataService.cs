using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string k = File.ReadAllText(path); ;
            string l = k.Replace(".", ",");

            double z = Convert.ToDouble(l);
            double i = Math.Round((((Math.Pow(z, 2)) / (Math.Sin(z))) + 3),3);
            return i;
        }
    }
}
