using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            double x = Convert.ToDouble(data);
            double y = Math.Cos(x) + Math.Pow(x, 2) / 2.0;
            return Math.Round(y, 3);
        }
    }
}
