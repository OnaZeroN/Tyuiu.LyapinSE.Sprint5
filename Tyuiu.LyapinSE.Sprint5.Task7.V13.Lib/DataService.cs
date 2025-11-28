using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LyapinSE.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string alpha = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string res = "";
            foreach (char a in text)
            {
                if (!(!char.IsUpper(a) && alpha.Contains(a)))
                    res += a;
            }
            File.WriteAllText(Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt"), res);
            return res;
        }
    }
}
