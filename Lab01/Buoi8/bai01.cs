using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai01
    {
        public static void xuly()
        {
            int n, k;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            k = int.Parse(Console.ReadLine());
            long kq = tinhtohop(n,k);
            Console.WriteLine("so to hop chap {0} cua {1} la: {2}", n,k,kq );
        }

        public static long  tinhtohop(int n,int k)
        {
            long hieu, tong,N,K,H;
            hieu = n - k;
            N = giaithua(n);
            K = giaithua(k);
            H = giaithua(hieu);

            tong = N / (H * K);

            // code run dont touch
            return tong;
        }

        public static long  giaithua(long n)
        {
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
    }
}
