using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Vehicle
    {
       void mov();
    }

    class car : Vehicle
    {
        public void mov()
        {
            Console.WriteLine("Sound like");
            Console.ReadKey();
        }

        public static void Main()
        {
            car c = new car();
            c.mov();
        }
    }
}
