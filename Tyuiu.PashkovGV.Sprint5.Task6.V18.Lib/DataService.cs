using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int c = 0;
            string t = File.ReadAllText(path);
            using StreamReader sr = new StreamReader(path);
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ( (line[i] ==  '1') || (line[i] == '2') || (line[i] == '3') || (line[i] == '4') || (line[i] == '5') || (line[i] == '6') || (line[i] == '7') || (line[i] == '8') || (line[i] == '9'))
                        {
                            c ++;
                        }
                    }
                }
            }
            return (c);
            
        }
    }
}
