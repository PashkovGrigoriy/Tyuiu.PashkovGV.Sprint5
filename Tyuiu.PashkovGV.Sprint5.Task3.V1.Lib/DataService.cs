using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string r = Path.GetTempPath();
            string p = Path.Combine(r, "OutPutFileTask3.bin");
            double z = ((Math.Pow(x, 3)) - 8 )/ (2 * (Math.Pow(x, 2)));
            z = Math.Round(z,3);
            using(BinaryWriter w = new BinaryWriter(File.Open(p, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                w.Write(BitConverter.GetBytes(z));
            }
            return(p);
        }
    }
}
