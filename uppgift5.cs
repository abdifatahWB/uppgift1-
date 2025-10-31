using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give number between 0 - 5");
            int grade = Convert.ToInt32(Console.ReadLine()); 

            switch (grade)

            {

                case 0:
                    Console.WriteLine("fail");
                    break;
                case 1:
                    Console.WriteLine("needs improvement");
                    break;
                case 2:
                    Console.WriteLine("ok");
                    break;
                case 3:
                    Console.WriteLine("satisfactory");
                    break;
                case 4:
                    Console.WriteLine("good");
                    break;
                case 5:
                    Console.WriteLine("excellent");
                    break;
                default: 
                    Console.WriteLine("fail");
                    break;
                }
            }
        }
    }
       
