using Tyuiu.KozyrevRA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int g = 1;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2.1.1";
            Assert.AreEqual(res, wait);
        }
    }
}
