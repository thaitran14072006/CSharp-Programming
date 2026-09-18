using System;

namespace console
{
    public static class bai01
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine()!);

            double[] num = new double[n];

            Console.Write($"Day so co {n} phan tu: ");
            string[] s = Console.ReadLine()!.Split();

            for (int i = 0; i < n; i++)
            {
                num[i] = double.Parse(s[i]);
            }

            double tong = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if ((num[i] > num[i - 1] && num[i] > num[i + 1]) ||
                    (num[i] < num[i - 1] && num[i] < num[i + 1]))
                {
                    tong += num[i];
                }
            }

            Console.WriteLine("Tong cac phan tu cuc tri co trong day so: " + tong);
        }
    }
}