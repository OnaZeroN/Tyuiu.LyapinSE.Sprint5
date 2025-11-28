using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = 3 * Math.Pow(x, 4) + (double)(1 / Math.Pow(x, 3));
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
