using System;
public class Exercise17
{
    public static void Main()
    {
        int cprice, sprice, amount;

        Console.Write("Input Cost Price: ");
        cprice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Selling Price: ");
        sprice = Convert.ToInt32(Console.ReadLine());

        if (sprice > cprice)
        {
            amount = sprice - cprice;
            Console.Write("\nYour profit amount : {0}\n", amount);
        }
        else if (cprice > sprice)
        {
            amount = cprice - sprice;
            Console.Write("\nYour loss amount : {0}\n", amount);
        }
        else
        {
            Console.Write("\nYou are running in no profit no loss condition.\n");
        }
        Console.ReadLine()

    }
}
