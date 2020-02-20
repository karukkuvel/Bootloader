using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierachary
{
    public class Parent
    {
       public int a = 10;
       public int b = 12;
       public int res = 0;

    }

    public class Base : Parent
    {
        public void add()
        {
            res = a + b;
            Console.WriteLine("The result is "+ res);
        }

        public static void Main()
        {
            Base b = new Base();
            b.add();
            Console.ReadKey();
        }
    }
}
