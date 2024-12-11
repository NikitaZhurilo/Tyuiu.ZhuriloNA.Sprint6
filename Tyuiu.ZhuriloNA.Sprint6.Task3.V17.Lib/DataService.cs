using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZhuriloNA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int k = 3;
            
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == k)
                    {
                        for (int g = 1; g < matrix.GetLength(0); g++)
                        {
                            int cur = matrix[g, i];
                            int z = g;
                            while (z > 0 && cur < matrix[z - 1, i])
                            {
                                matrix[z, i] = matrix[z - 1, i];
                                z--;
                            }
                            matrix[z, i] = cur;
                        }
                    }

                }
            }
            return matrix;
        }
    }
}
