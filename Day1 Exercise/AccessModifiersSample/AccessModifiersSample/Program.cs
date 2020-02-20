using System;

public class Pro
{
    public int i = 20;
    private int j = 10;
    void fun()
    {
        Console.WriteLine(j);
    }
}

public class Program
{

    public static void Main()
    {
        Pro p = new Pro();

        Console.WriteLine(p.i);
        //Console.WriteLine(p.j);  //'P.j' is inaccessible due to its protection level
    }
}

