using Tyuiu.KozyrevRA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            var ds = new DataService();
            int g =2024;
            int m = 9;
            int n = 8;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "09.09.2024";
            Assert.AreEqual(res, wait);
        }
    }
}
