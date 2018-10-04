using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гипотенуза
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//Первый катет
            int b = Convert.ToInt32(Console.ReadLine());//Второй катет
            Console.WriteLine("Гипотенуза"+":"+Math.Sqrt(a * a + b * b));//Гипотенуза
            double c = Convert.ToDouble(Console.ReadLine());//Гипотенуза
            double h = Convert.ToDouble(Console.ReadLine());//Катет
            Console.WriteLine("Неизвестный катет" + ":" + Math.Sqrt(c*c-h*h));//Неизвестный катет
            Console.ReadLine();
        }
    }
}
