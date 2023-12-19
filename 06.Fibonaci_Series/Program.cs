using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fibonaci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int No1 = 1, No2 = 0, No3 = 0, Cnt = 0;

            Console.WriteLine("Enter Count = ");
            Cnt = Convert.ToInt32(Console.ReadLine());

            while (Cnt != 0)
            { 
                Console.Write(" {0}", No3);
                No3 = No1 + No2;
                No1 = No2;
                No2 = No3;
                Cnt--;
            }
            Console.ReadLine();
          }
    }
}
