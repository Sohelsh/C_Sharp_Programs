using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Table_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            Console.Write("Enter Starting Number = ");
            int SNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Ending Number = ");
            int ENo = Convert.ToInt32(Console.ReadLine());

            for(j = 1; j <= 10; j++) 
            {
                for(i = SNo; i <= ENo; i++)
                {
                    Console.Write(" {0} ", j * i);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
