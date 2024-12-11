using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZhuriloNA.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path)) 
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    len++;
                }
            }
            double[] data = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path)) 
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    data[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            data = data.Where(x => x == 0).ToArray();
            return data;
        }
    }
}
