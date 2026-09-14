using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai04
    {
        public static void xuly()
        {
            float[] a = null;
            nhapDaySo(ref a);
            Console.WriteLine("So nhan xuat hien x trong mang la: {0}", timx(a));
            daucuoi(a);

        }

        public static void nhapDaySo(ref float[] day)
        {
            int i, n;
            Console.Write("Nhap so phan tu n: ");
            n = int.Parse(Console.ReadLine());
            day = new float[n];

            for( i = 0; i < day.Length ; i++)
            {
                Console.Write("Phan tu thu {0}:", i);
                day[i] = float.Parse(Console.ReadLine());
            }
        }

        public static float timx(float[] day)
        {

            float x,count=0;
            Console.Write("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            for(int i = 0; i < day.Length; i++)
            {
                if(day[i] == x)
                {
                    count++;
                }
            }

            return count;
        }

        public static void daucuoi(float[] day)
        {
            float dau, cuoi;
            dau = day[0];
            cuoi = day[day.Length - 1];
            Console.WriteLine("Gia tri dau la: {0}", dau);
            Console.WriteLine("Gia tri cuoi la: {0}", cuoi);
        }
    }
}
