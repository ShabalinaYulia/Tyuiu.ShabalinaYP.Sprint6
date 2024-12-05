using Tyuiu.ShabalinaYP.Sprint6.Task4.V1.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService();
            int start = -5;
            int stop = 5;
            double[] wait = new double[]
            {
                - 12.18, 16.03, 18.87, 4.96, -9.99, -2, 2.16, -7.54, -22.76, -20.45, 7.77 
            };
            double[] res = dataService.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
