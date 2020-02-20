using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for Identical number");
            Console.WriteLine("Enter the first number:");
            var frst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            var Sec = Convert.ToInt32(Console.ReadLine());
            if (frst == Sec)
            {
                Console.WriteLine("Both are identical");
            }
            else
            {
                Console.WriteLine("Not Identical");
            }
            Console.ReadKey();

        }
    }
}
