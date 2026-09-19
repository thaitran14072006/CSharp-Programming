using System;
namespace console;

public static class bai01
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] a = new int[n];

        // Nhập mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i}: ");
            a[i] = int.Parse(Console.ReadLine()!);
        }

        Console.Write("Cac phan tu chan trong mang: ");

        // Duyệt từ phải sang trái
        for (int i = n - 1; i >= 0; i--)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();
    }
}