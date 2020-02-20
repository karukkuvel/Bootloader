using System;
class Sum_Mul
{
    public static void Main()
    {
        int a, b, i, Sum = 0,num;
        Console.WriteLine("enter the number upto which ");
        num = Convert.ToInt32(Console.ReadLine());
        
        for (i = 1; i < num; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                Sum = Sum + i;
            }
        }
        Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}",
                          Sum);
        Console.Readkey();
    }
}