using Tyuiu.ZhuriloNA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -2.556;
            Assert.AreEqual(wait, res);
        }
    }
}