using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Символы
{
    class Program
    {
        static void Main(string[] args)
        {
             String a = Console.ReadLine();
            Console.WriteLine(a[2]);//1
            Console.WriteLine();
            Console.WriteLine(a[a.Length - 2]); // 2;
            Console.WriteLine();
            for (int i=0;i<5;i++)//3
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length-2; i++) //4
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i=0;i<=a.Length;i+=2)//5
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 1; i <= a.Length-1; i += 2) //6 
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int b= a.Length; b > 0; b--) //7
            {
                if(b > a.Length) break;
                Console.WriteLine(a[b - 1]);
            }
            Console.WriteLine();
            for (int b = a.Length; b >= 0;b-=2) //8 
            {
                Console.WriteLine(a[b-1]);  
            }
            Console.WriteLine();
            Console.WriteLine(a.Length);//9
            Console.ReadLine();
        }
    }
}
