using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai01
    {
        public static void nhapMang(ref int[] day)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            day = new int[n];
            for (int i = 0; i < day.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                day[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void xapxepchanle(int[] day)
        {
            for (int i = 0;i< day.Length; i++)
            {
                for(int j = i+1; j< day.Length; j++)
                {
                    if (day[i] % 2 !=0 && day[j] % 2 == 0)
                    {
                        int tmp = day[i];
                        day[i] = day[j];
                        day[j] = tmp;
                    }else if (day[i] % 2 == 0 && day[j] % 2 == 0)
                    {
                        if (day[i] > day[j])
                        {
                            int tmp = day[i];
                            day[i] = day[j];
                            day[j] = tmp;
                        }
                    }
                    else if (day[i] % 2 != 0 && day[j] % 2 != 0)
                    {
                        if (day[i] < day[j])
                        {
                            int tmp = day[i];
                            day[i] = day[j];
                            day[j] = tmp;
                        }
                    }
                }
            }
        }
        public static void inMang(int[] day)
        {
            for (int i = 0; i <= day.Length-1; i++)
            {
                Console.Write(day[i] + " ,");
            }
        }

        public static void xuly()
        {
            int[] a = null;
            nhapMang(ref a);
            xapxepchanle(a);
            Console.Write("day so co: ");
            inMang(a);
            
        }
    }
}
