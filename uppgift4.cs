using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 1;

            if (age >= 18)
            {
                Console.WriteLine("yes old enough to vote");
            }
            else 
            {
                Console.WriteLine("NO! your not old enough to vote, try next year again");
            }
                
        }
    }
}
