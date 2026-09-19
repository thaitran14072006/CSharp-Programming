using System;
namespace console;  

public static class bai04
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] dem = new int[10];

        while (n > 0)
        {
            int chuSo = n % 10;
            dem[chuSo]++;
            n /= 10;
        }

        for (int i = 0; i <= 9; i++)
        {
            if (dem[i] > 0)
            {
                Console.WriteLine($"Chu so {i} xuat hien {dem[i]} lan.");
            }
        }
    }
}