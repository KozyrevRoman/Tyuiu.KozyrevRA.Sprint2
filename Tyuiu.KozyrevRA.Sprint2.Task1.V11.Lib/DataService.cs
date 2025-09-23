using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KozyrevRA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a>b)|(c<d);
            res[1] = (a+11!=b)&(c<d);
            res[2] = (a+11>=b)||(c>=d);
            res[3] = (a!=b+3)&&(c==d);
            res[4] = !(a > b) == (c >= d);
            res[5] = (a > b + 70) ^ (c < d);
            return res;
        }
    }
}
