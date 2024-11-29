using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabalinaYP.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue-startValue + 1];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Sin(i) - 2) == 0)
                {
                    values[index] = 0;
                    index++;
                    continue;
                }
                values[index] = Math.Round((5 * i + 2.5) / (Math.Sin(i) - 2) + 2, 2);
                index++;
            }
            return values;
        }
    }
}
