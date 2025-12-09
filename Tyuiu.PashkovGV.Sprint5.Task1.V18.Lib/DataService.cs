using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string r = Path.GetTempPath();
            string p = Path.Combine(r, "OutPutFileTask1.txt");
            
            
            
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i != 0)
                {
                    if (i != stopValue)
                    {
                        double z = (3 * i) + 2 - (((2 * i) - i) / (Math.Cos(i) + 1));
                        z = Math.Round(z, 2);
                        string zz = Convert.ToString(z);
                        File.AppendAllText(p, zz + Environment.NewLine);
                    }
                    else
                    {
                        double z = (3 * i) + 2 - (((2 * i) - i) / (Math.Cos(i) + 1));
                        z = Math.Round(z, 2);
                        string zz = Convert.ToString(z);
                        File.AppendAllText(p, zz);
                    }
                }
                else
                {
                    int z = 2;
                    string zz = Convert.ToString(z);
                    File.AppendAllText(p, zz + Environment.NewLine);
                }
            }
            return p;
        }
    }
}
