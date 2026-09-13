using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            int n;

            Console.Write("Moi nhap n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so hoan hao tu 1 den " + n + ":");

            for (int i = 1; i <= n; i++)
            {
                int tong = 0;

                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        tong += j;
                    }
                }

                if (tong == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
