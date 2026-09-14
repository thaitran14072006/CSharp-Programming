using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai02
    {
        public static void xuly()
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao tu [1,{0}] theo thu tu giam dan la: " , n);

            for(int i = n; i >= 1; i--)
            {
                if(sohoanhao(i)!=0) Console.Write(" "+i);
            }
        }
        public static int sohoanhao(int n)
        {
            int tong=0;
            for (int i = 1; i <= ((int)Math.Sqrt(n));i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                    if (i != n / i)
                    {
                        tong += n / i;
                    }
                }
            }

            tong -= n;

            if(tong == n)
            {
                return n;
            } return 0;
        }
    }
}
