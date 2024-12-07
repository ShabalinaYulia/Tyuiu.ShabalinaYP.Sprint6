﻿using Tyuiu.ShabalinaYP.Sprint6.Task5.V29.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint6\Tyuiu.ShabalinaYP.Sprint6.Task5.V29\InPutDataFileTask5V29.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 12.89, 35, 13.83, 12.76 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
