using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            double product = 1;


            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] numbers = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var numberStr in numbers)
                    {

                        if (int.TryParse(numberStr, out int number) && number % 2 != 0)
                        {
                            product *= number;

                        }
                    }
                }
            }

            return Math.Round(product, 3);
        }
    }
}
