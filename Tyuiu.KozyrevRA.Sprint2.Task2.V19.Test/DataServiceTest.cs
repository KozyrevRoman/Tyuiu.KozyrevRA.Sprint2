using Tyuiu.KozyrevRA.Sprint2.Task2.V19.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res,wait);
        }
    }
}
