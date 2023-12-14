using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, Revs = "";

            Console.WriteLine("Emter String ");
            Str = Console.ReadLine();

            for(int i = Str.Length - 1; i >= 0;i--)
            {
                Revs += Str[i].ToString();
  
            }

            if (Str == Revs )
            {
                Console.WriteLine("String Is Palindrome = {0}",Str);
            }
            else
            {
                Console.WriteLine("String Not Palindrome = {0}", Str);
            }

            Console.ReadLine();
           
        }
    }
}
