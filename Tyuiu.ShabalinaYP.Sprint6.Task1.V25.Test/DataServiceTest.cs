using Tyuiu.ShabalinaYP.Sprint6.Task1.V25.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = new double[]
            {
                23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
