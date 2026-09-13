using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai06
    {
        public static void xuly()
        {
            int a, n,kq;
            Console.Write("Moi nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap n: ");
            n = int.Parse(Console.ReadLine());
            kq = (int)Math.Pow(a, n);
            Console.WriteLine("Ket qua " + a + "^" + n + " la: " + kq);
        }
    }
}
