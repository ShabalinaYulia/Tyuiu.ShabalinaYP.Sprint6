using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabalinaYP.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(Math.Sin(i) / (i + 1.2) + Math.Cos(i) * 7 * i - 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
