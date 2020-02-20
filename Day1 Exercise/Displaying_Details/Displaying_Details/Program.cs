using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your Department:");
        string Dept = Console.ReadLine();
        Console.WriteLine("Designation\n");
        string Des = Console.ReadLine();
        Console.WriteLine("******* Details *********");
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your Department is: " + Dept);
        Console.WriteLine("Your Designation is: " + Des);


    }
}