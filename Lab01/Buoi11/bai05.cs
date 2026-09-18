using System;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            Console.Write("Nhap so phan tu cua day A: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] a = new int[n];
            Console.Write($"Day so co {n} phan tu: ");
            string[] s1 = Console.ReadLine()!.Split();

            for (int i = 0; i < n; i++)
                a[i] = int.Parse(s1[i]);

            Console.Write("Nhap so phan tu cua day B: ");
            int m = int.Parse(Console.ReadLine()!);

            int[] b = new int[m];
            Console.Write($"Day so co {m} phan tu: ");
            string[] s2 = Console.ReadLine()!.Split();

            for (int i = 0; i < m; i++)
                b[i] = int.Parse(s2[i]);

            int[] c = new int[n + m];

            int ia = 0, ib = 0, ic = 0;

            while (ia < n && ib < m)
            {
                if (a[ia] < b[ib])
                    c[ic++] = a[ia++];
                else
                    c[ic++] = b[ib++];
            }

            while (ia < n)
                c[ic++] = a[ia++];

            while (ib < m)
                c[ic++] = b[ib++];

            Console.Write($"Day so co {n + m} phan tu: ");
            for (int i = 0; i < n + m; i++)
                Console.Write(c[i] + " ");
        }
    }
}