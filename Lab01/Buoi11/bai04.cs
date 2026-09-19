using System;
namespace console;

public static class bai04
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] a = new int[n];

        // Nhap day so
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i}: ");
            a[i] = int.Parse(Console.ReadLine()!);
        }

        // Mang truoc khi dao
        Console.Write("Mang truoc dao: ");
        Console.Write($"Day so co {n} phan tu: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();

        // Dao mang
        for (int i = 0; i < n / 2; i++)
        {
            int temp = a[i];
            a[i] = a[n - 1 - i];
            a[n - 1 - i] = temp;
        }

        // Mang sau khi dao
        Console.Write("Mang sau khi dao: ");
        Console.Write($"Day so co {n} phan tu: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }
}