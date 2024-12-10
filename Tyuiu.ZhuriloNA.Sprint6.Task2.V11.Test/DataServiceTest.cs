using Tyuiu.ZhuriloNA.Sprint6.Task2.V11.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] array;
            array = new double[len];
            array[0] = 13.81;
            array[1] = 11.87;
            array[2] = 9.87;
            array[3] = 7.74;
            array[4] = 5.36;
            array[5] = 2.5;
            array[6] = 0;
            array[7] = 0.79;
            array[8] = -1.75;
            array[9] = -3.78;
            array[10] = -5.71;
            double[] array2;
            array2 = new double[len];
            array2 = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(array, array2);
        }
    }
}