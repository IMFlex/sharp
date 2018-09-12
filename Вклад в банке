using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int k=0;
            double u = 0;
              x =(x*p/100)+x;
             y = (y * p / 100) + y;
            u = x*100 - (int)x*100;//разность между 40.95 и 40(относительно третьего теста)
            y += (int)u;//прибавляет разность между 40.95 и 40 к копейкам
            if (y >= 100)//проверка условия на больше или равно
            {
                k = y / 100;//выделаяет рубли от копеек
            }
            //Console.WriteLine((rub + k-u/100) + " " + (cop-(k * 100)));
            Console.WriteLine((x + k - u / 100) + " " + (y - (k * 100)));//1-рубли + рубли от копеек - разность между 40.95 и 40 деленная на 100
            //2 - копейки минус в скобках выделение рублей от копеек умноженное на 100
            Console.ReadLine();
        }
    }
}
