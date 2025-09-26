using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.KozyrevRA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства: «валету» —11, «даме» —12, «королю» —13,  *");
            Console.WriteLine("* «тузу» —14.Порядковые номера остальных карт соответствуют их названиям  *");
            Console.WriteLine("* («шестерка», «девятка» и т. п.).                                        *");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <= 14) определить достоинство        *");
            Console.WriteLine("* соответствующей карты.                                                  *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("Введите номер игральной карты: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((x < 6) || (x > 14)) 
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Эта карта: " + ds.FindCardValue(x);
            }
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}