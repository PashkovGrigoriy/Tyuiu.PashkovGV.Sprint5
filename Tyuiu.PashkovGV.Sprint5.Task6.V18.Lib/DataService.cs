using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            string s = File.ReadAllText(path);
            string[] words = s.Split(' ');
            int c = 0;
            foreach(string w in words)
            {
                if ( (w == "1") || (w == "2") || (w == "3") || (w == "4") || (w == "5") || (w == "6") || (w == "7") || (w == "8") || (w == "9"))
                {
                    c++;
                }

            }
            return c;
        }
    }
}
