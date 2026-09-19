using System;
namespace console;

public static class bai03
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] a = new double[n];

        Console.WriteLine("Nhap day so:");

        for (int i = 0; i < n; i++)
        {
            a[i] = double.Parse(Console.ReadLine()!);
        }

        bool danDau = true;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] * a[i + 1] >= 0)
            {
                danDau = false;
                break;
            }
        }

        if (danDau)
            Console.WriteLine("Day so co tinh chat dan dau.");
        else
            Console.WriteLine("Day so khong co tinh chat dan dau.");
    }
}