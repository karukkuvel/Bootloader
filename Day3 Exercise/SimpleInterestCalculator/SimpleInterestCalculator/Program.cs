using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,n,r;
            int res;
            Console.WriteLine("*** Basic Simple interest Calculator ***");
            Console.WriteLine("Principle in rupees:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Year ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest");
            r = Convert.ToInt32(Console.ReadLine());
            res = (p * n * r) / 100;
            Console.WriteLine("Simple Interest is " + res + "rupees");
            Console.ReadKey();
        }
    }
}
