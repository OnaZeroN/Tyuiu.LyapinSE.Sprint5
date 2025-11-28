using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new(path);

            if (fileInfo.Exists) 
            {
                File.Delete(path);
            }

            double y;
            string res;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0.4)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(x) / (double)(x - 0.4) + Math.Sin(x) * 8 * x + 2;
                }

                res = Convert.ToString(Math.Round(y, 2));

                if (x != stopValue)
                {
                    File.AppendAllText(path, res + Environment.NewLine);
                } 
                else
                {
                    File.AppendAllText(path, res);
                }
            }
            return path;
        }
    }
}
