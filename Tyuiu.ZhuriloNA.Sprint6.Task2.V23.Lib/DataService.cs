using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZhuriloNA.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                if (2 * x - 2 != 0)
                {
                    result[count] = y;
                    count++;
                }
                else
                {
                    result[count] = 0;
                    count++;
                }
            }
            return result;
        }
    }
}