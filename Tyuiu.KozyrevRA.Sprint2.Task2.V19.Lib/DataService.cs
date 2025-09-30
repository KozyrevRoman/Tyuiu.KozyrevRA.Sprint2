using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KozyrevRA.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x >= 3) && (x < 5) && (y >= 3) && (y < 5)) || ((x >= 3) && (x < 11) && (y >= 5) && (y < 8)) ||
                    ((x >= 9) && (x < 11) && (y >= 3) && (y < 5)) || ((x >= 11) && (x < 13) && (y == 3))
                    || ((x == 6) && (y >= 8) && (y < 12)) || ((x >= 9) && (x < 11) && (y >= 3) && (y < 5)) 
                    || ((y == 11) && (x >= 3) && (y < 7)) || ((x >= 11) && (x < 14) && (y >= 6) && (y < 9)) 
                    || ((x >= 11) && (x < 13) && (y >= 9) && (y < 12)) || ((x >= 9) && (x < 12) && (y >= 11) && (y < 15))
                    || ((x >= 7) && (x < 9) && (y == 13)) || ((x >= 12) && (x < 14) && (y == 14))) 
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
