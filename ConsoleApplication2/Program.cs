using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Buy elephant!");
            Console.WriteLine("Enter 'Yes' or 'No'");
            string i,s;
            i = Console.ReadLine();
            if (i == "Ok" | i == "ok") 
            {
                Console.WriteLine("Just a moment.. Searching... Error. Please restart.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("All say " + i+", but buy!");
                s = Console.ReadLine();
            }

                    
        }
    }

    
}
