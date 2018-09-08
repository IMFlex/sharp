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
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int k=0;
            //double full_procent =p*0.01;
            double rub =(x*p/100)+x;
            int cop = (y * p / 100) + y;
            if (cop > 100)
            {
                k = cop / 100;
            }
            Console.WriteLine((rub + k) + " " + (k * 100));
            Console.ReadLine();
        }
    }
}
