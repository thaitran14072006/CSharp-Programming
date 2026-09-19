using System;

public static class bai01
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so n: ");
        int n = int.Parse(Console.ReadLine());

        int giaiThua = 1;

        Console.Write($"{n}! = ");

        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;

            if (i < n)
                Console.Write($"{i}.");
            else
                Console.Write($"{i}");
        }

        Console.WriteLine($" = {giaiThua}");
    }
}