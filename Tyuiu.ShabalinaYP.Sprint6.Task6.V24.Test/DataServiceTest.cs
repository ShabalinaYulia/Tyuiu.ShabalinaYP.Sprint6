using Tyuiu.ShabalinaYP.Sprint6.Task6.V24.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollect()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\InPutDataFileTask6V24.txt";
            string[] res = ds.CollectTextFromFile(path).Split(' ');
            string[] wait = ["EovFJ", "Vud", "RgdW", "KwQBrOM", "Ewyq"];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
