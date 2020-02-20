using System;

namespace Factorial
{
    public class factoral
    {
       
        public int number = Convert.ToInt32(Console.ReadLine());
        int fac = 1;

        public void fact()
        {

            for (int i = 1; i <= number; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            
            factoral f = new factoral();


            f.fact();
        }
    }
}