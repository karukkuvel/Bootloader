using System;

namespace Exercise
{
    public class Sample
    {
        int a = 15;
        int b = 10;
        int res = 0;
        public void add()
        {
            res = a + b;
            Console.WriteLine(res);
        }

        public void sub()
        {
            res = a - b;
            Console.WriteLine(res);
        }

        public static void Main(string[] args)
        {
            Sample s = new Sample();
            s.add();
            s.sub();
        }
    }
}