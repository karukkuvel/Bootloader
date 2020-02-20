using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, iter;
            Console.Write("\n\n");
            Console.Write("Display the multiplication table:\n");
            Console.Write("\n\n");
            Console.Write("Input the number (Table to be calculated) : ");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (iter = 1; iter <= 10; iter++)
            {
                Console.WriteLine("{0}*{1}={2}", number, iter, number * iter);    
            }
            Console.ReadKey();
        }
    }
}
