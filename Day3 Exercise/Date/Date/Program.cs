using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
     
    class Program
        {
            static int Main()
            {
                DateTime time = DateTime.Now;
                string format = "MMM ddd d HH:mm yyyy";
                Console.WriteLine(time.ToString(format));
                Console.Read();
                return 0;
            }
        }

    
}
