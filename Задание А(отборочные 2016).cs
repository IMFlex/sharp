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
             int s = Convert.ToInt32(Console.ReadLine());
             int v1 = Convert.ToInt32(Console.ReadLine());
             int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во секунд" + " " + s / ((v1 + v2) / 3.6));
            Console.ReadLine();
        }
    }
}
