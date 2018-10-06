using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Максимальный_делитель_Отборочный_тур__2016_года_
{
    class Program
    {
        static void Main(string[] args)
        {
          int i = Convert.ToInt32(Console.ReadLine());
          int[] num = new int[i];
           for (int b=0;b<i;b++)
            {
                num[b] = Convert.ToInt32(Console.ReadLine());
                   if(num[b]%2==0)
                    {
                        Console.WriteLine(num[b]/2);
                    }
                   else if(num[b]%2!=0)
                    {
                        Console.WriteLine(1);
                    }
             }
            Console.ReadKey();
        }
    }
}
