using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Find_Max_In_Two_Num
{
    class Calculation
    {
        public int Find_Max(int No1,int No2)
        {
            int Result;
            if(No1 < No2)
            {
                Result = No2;
            }
            else
            {
                Result = No1;
            }
            return Result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 50, N2 = 25;

            Calculation Obj = new Calculation();
            Console.WriteLine("{0}",Obj.Find_Max(N1, N2));
            Console.ReadLine();
        }
    }
}
