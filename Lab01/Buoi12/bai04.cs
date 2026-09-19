using System;
using System.Collections.Generic;
namespace console;

public static class bai04
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so dong n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Moi ban nhap so cot m: ");
        int m = int.Parse(Console.ReadLine()!);

        int[,] A = new int[n, m];

        // Nhap ma tran
        Console.WriteLine("Nhap ma tran:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        // Liet ke cac dong tang dan
        Console.Write("Cac dong tao thanh day tang: ");

        for (int i = 0; i < n; i++)
        {
            bool tang = true;

            for (int j = 0; j < m - 1; j++)
            {
                if (A[i, j] >= A[i, j + 1])
                {
                    tang = false;
                    break;
                }
            }

            if (tang)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}