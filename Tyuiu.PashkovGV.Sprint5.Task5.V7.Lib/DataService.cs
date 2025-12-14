using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PashkovGV.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string t = File.ReadAllText(path);
            string n = new string(t
                .SkipWhile(c => !char.IsDigit(c))  // Пропускаем не-цифры
                .TakeWhile(char.IsDigit)           // Берём цифры
                .ToArray());

            int u = int.Parse(n);
            int res = 1;
            for (int i = 1; i <= u; i++)
            {
                res = i * res;
            }
            return res;
        }
    }
}
