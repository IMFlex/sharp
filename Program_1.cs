using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первое_испытание
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            int n = Int32.Parse(a);
            Console.WriteLine(n % 1440 / 60);
            Console.WriteLine(n % 60);
            Console.ReadLine();
        }
    }
}
