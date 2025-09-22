using Tyuiu.KozyrevRA.Sprint2.Task0.V28.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 111;
            int y = 735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, false, false, false };
        }
    }
}
