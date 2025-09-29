using tyuiu.cources.programming.interfaces.Sprint2;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth;
            switch (m)
            {
                case 1: daysInMonth = 31;break; 
                case 2: daysInMonth = 29; break;
                case 3: daysInMonth = 31; break;
                case 4: daysInMonth = 30; break;
                case 5: daysInMonth = 31; break;
                case 6: daysInMonth = 30; break;
                case 7: daysInMonth = 31; break;
                case 8: daysInMonth = 31; break;
                case 9: daysInMonth = 30; break;
                case 10: daysInMonth = 31; break;
                case 11: daysInMonth = 30; break;
                case 12: daysInMonth = 31; break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++; 
                }
            }
            string res;
            if ((n < 10) && (m<10))
            {
                res = $"0{n}.0{m}.{g}";
            }
            else if ((n < 10) && (m > 10))
            {
                res = $"0{n},{m}.{g}";
            }
            else if ((n > 10) && (m < 10))
            {
                res = $"{n},0{m}.{g}";
            }
            else
            {
                res = $"{n}.{m}.{g}";
            }
            return res;
        }

    }
}
