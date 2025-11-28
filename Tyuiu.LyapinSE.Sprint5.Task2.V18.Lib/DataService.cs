using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string stringMatrix = ConvertMatrixToCSVString(ConvertMatrixItems(matrix));
            File.AppendAllText(path, stringMatrix);

            return path;
        }

        private static int[,] ConvertMatrixItems(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        private static string ConvertMatrixToCSVString(int[,] matrix)
        {
            string row = "";
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row += matrix[i, j];
                    if (j != matrix.GetLength(1) - 1)
                    {
                        row += ";";
                    }    
                }

                result += row;
                if (i == matrix.GetLength(0) - 1)
                {
                    result += Environment.NewLine;
                }
                row = "";
            }
            return result;
        }
    }
}
