using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                string[] lineArr = line.Split(' ');
                int cntr = 0;
                foreach (string s in lineArr)
                {
                    if (s.Length == 2)
                    {
                        cntr++;
                    }
                }
                return cntr;
            }
        }
    }
}
