using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial_Of_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fact = 1, No;

            Console.Write("\n Enter Number = ");
            No = Convert.ToInt32(Console.ReadLine());

            while(No !=  0)
            {
                Fact = Fact * No;
                No--;
            }

            Console.Write("Factorial Of Number =  {0}",Fact);

            Console.ReadKey();
        }
    }
}
