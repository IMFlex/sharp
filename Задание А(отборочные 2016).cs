using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Задача_отборочные_2016г._
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            double s = double.Parse(num[0]);
            double v1 = double.Parse(num[1]);
            double v2 = double.Parse(num[2]);
            Console.WriteLine(s / ((v1 + v2) / 3.6));
            Console.ReadLine();
        }
    }
}
