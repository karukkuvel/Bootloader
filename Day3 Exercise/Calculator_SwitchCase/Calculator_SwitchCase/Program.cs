using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_SwitchCase
{
    public class Calculator {
        public static void Main()
        {
            int res = 0;
            Console.WriteLine("Enter the operand1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operand2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Following operation can be performed");
            Console.WriteLine("1.Add 2.Sub 3.Multiply 4.Divide");
            var choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {

                case 1:
                    {
                        res = num1 + num2;
                        Console.WriteLine("The result is " + res);
                        break;
                    }
                case 2:
                    {
                        res = num1 - num2;
                        Console.WriteLine("The result is " + res);
                        break;
                    }
                case 3:
                    {
                        res = num1 * num2;
                        Console.WriteLine("The result is " + res);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            res = num1 / num2;
                
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e);
                            break;
                        }
                        Console.WriteLine("The result is " + res);
                        break;
                        
                    }
                default:
                    {
                        Console.WriteLine("It is not a valid operation Still Calculator is in beta Version :(");
                        break;
                    }
            }
            Console.ReadKey();


        }
    
    }
}
