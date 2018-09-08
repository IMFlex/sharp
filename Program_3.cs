using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == c && b == c)
            {
                Console.WriteLine("все совпадают-->3");
            }
            else if (a == b || a == c || c == b)
            {
                Console.WriteLine("два совпадают-->2");
            }
            else if (a != b && b != c)
            {
                Console.WriteLine("все числа различны-->0");
            }
            
            Console.ReadLine();
        }
    }
}
