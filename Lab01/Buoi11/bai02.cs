using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai02
    {
        public static void nhapMang(ref int[] day)
        {
            int n;
            Console.Write("Nhap so phan tu: ");
            n = int.Parse(Console.ReadLine());
            day = new int[n];
            for(int i =0;i< day.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                day[i] = int.Parse(Console.ReadLine());
            }

        }

        public static int[] thuhepday(int[] day, int n)
        {
            int[] daymoi = new int[day.Length - n];

            for (int i = 0; i < daymoi.Length; i++)
            {
                daymoi[i] = day[i];
            }

            return daymoi;
        }

        public static void xoaphantu(ref int[] day,int vitri)
        {
            for (int i = vitri + 1; i < day.Length; i++)
            {
                day[i-1] = day[i];
            }

            day = thuhepday(day, 1);
        }

        public static void inMang(int[] day)
        {
            for (int i = 0; i <= day.Length - 1; i++)
            {
                Console.Write(day[i] + " ,");
            }
        }

        public static void xuly()
        {
            int[] a = null;
            nhapMang(ref a);
            for(int i=0;i<a.Length;i++)
            {
                if(a[i] % 2 == 0)
                {
                    xoaphantu(ref a, i);
                    i--;
                }
            }

            inMang(a);

        }
    }
}
