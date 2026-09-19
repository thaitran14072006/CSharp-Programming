using System;
namespace console;

public static class bai03
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine()!);

        int temp = n;
        bool first = true;

        Console.Write($"{n} = ");

        for (int i = 2; i <= temp; i++)
        {
            int dem = 0;

            while (temp % i == 0)
            {
                temp /= i;
                dem++;
            }

            if (dem > 0)
            {
                if (!first)
                    Console.Write(" x ");

                Console.Write(i);

                if (dem > 1)
                    Console.Write($"^{dem}");

                first = false;
            }
        }

        Console.WriteLine();
    }
}