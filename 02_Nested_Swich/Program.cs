using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Nested_Swich
{
    class Program
    {
        static void Main(string[] args)
        {
            string Day = "";
            string Date = "";
            Day = Console.ReadLine();
            Date = Console.ReadLine();
            switch (Day)
            {
                case "Monday":
                    Console.WriteLine("Its Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Its Tuesday");

                    switch(Date)
                    {
                        case "5":
                            Console.WriteLine("Date :1");
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
