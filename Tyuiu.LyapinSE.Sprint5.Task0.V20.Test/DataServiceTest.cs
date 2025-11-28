using Tyuiu.LyapinSE.Sprint5.Task0.V20.Lib;


namespace Tyuiu.LyapinSE.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\stepan\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}