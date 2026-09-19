using System;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            int n, m;

            Console.Write("Nhap so dong: ");
            n = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so cot: ");
            m = int.Parse(Console.ReadLine()!);

            int[,] A = new int[n, m];

            Console.WriteLine("Nhap ma tran:");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine()!.Split(' ');

                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            int maxTong = int.MinValue;

            for (int j = 0; j < m; j++)
            {
                int tong = 0;

                for (int i = 0; i < n; i++)
                {
                    tong += A[i, j];
                }

                if (tong > maxTong)
                {
                    maxTong = tong;
                }
            }

            Console.Write("Cac cot co tong lon nhat: ");

            for (int j = 0; j < m; j++)
            {
                int tong = 0;

                for (int i = 0; i < n; i++)
                {
                    tong += A[i, j];
                }

                if (tong == maxTong)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}