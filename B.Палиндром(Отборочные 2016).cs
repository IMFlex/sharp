using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Палиндром_Отборочные_2016г._
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string a = Convert.ToString(Console.ReadLine());
            for (int b = a.Length; b > 0; b--) //7
            {
                if (b > a.Length) break;
                Console.WriteLine(a[b - 1]);
            }
            Console.ReadKey();
        }


        
        
    }
}
