using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Find_The_Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,i;
           for (i = 1;i <= 100;i++)
            {
                for(j = 2; j <= i;j++)
                {
                    if(i % j == 0)
                    {
                        break;
                    }
                }
                if(i == j)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
