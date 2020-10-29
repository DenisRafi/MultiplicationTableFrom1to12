using System;

public class ByDenisRafi
{
    public static void Main()
    {
        Console.Title = "Multiplication table from 1 to 12";
        int j, i, n;
        Console.Write("Display the multiplication table 1 to n:\n");
        Console.Write("Input upto the table number starting from 1 : ");
        Console.Write("\n\n");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Multiplication table from 1 to {0} \n", n);
        Console.Write("\n\n");
        for (i = 1; i <= 10; i++)
        {
            for (j = 1; j <= n; j++)
            {
                if (j <= n - 1)
                    Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                else
                    Console.Write("{0}x{1} = {2}", j, i, i * j);

            }
            Console.Write("\n");            
        }
    }
}