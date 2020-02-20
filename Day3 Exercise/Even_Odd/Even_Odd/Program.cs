using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    class EvenROdd
    {
        public void Check(int a)
        {
            int num1 = a;
            if (num1 % 2 == 0)
            {
                Console.WriteLine("\n"+num1 + " is a Even Number");
            }
            else
            {
                Console.WriteLine(num1 + " is a Odd number");

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EvenROdd obj = new EvenROdd();
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            obj.Check(a);
            Console.ReadKey();
                

        }
    }
}
