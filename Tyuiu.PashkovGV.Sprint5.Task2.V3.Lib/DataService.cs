using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PashkovGV.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V2
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string r = Path.GetTempPath();
            string p = Path.Combine(r, "OutPutFileTask2.txt");

            int st = matrix.GetUpperBound(0) + 1;
            int ct = matrix.Length / st;
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < ct; j++)
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
            }
            string str = "";
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < ct; j++)
                {
                    if (j != ct - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != st - 1)
                {
                    File.AppendAllText(p, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(p, str);
                }
                str = "";
            }
            return p;
        }
    }
}
