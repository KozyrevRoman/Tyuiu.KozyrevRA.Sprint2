using Tyuiu.KozyrevRA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait =13.0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10; 
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 20.150;
            Assert.AreEqual(wait, res);
        }
    }
}
