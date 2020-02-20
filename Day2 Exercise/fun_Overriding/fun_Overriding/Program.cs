using System;
namespace Fun_Overriding
{
    class BaseClass
    {
        public int num1 , num2;
        public virtual int Add()
        {
            return (num1+num2);
        }
    }
    class ChildClass : BaseClass
    {
        public override int Add()
        {
                
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First value : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Sec value : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                return (num1 + num2);
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            ChildClass child = new ChildClass();
            Console.WriteLine("Child class method Add :" + child.Add());
            Console.ReadLine();
        }
    }
}