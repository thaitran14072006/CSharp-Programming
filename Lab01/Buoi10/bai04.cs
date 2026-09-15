using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace console
{
    public class bai04
    {
        public static void xuly()
        {
            int[] a = null;
            int vitridau, vitricuoi;
            nhapsayso(ref a);
            timtong(a, out vitridau, out vitricuoi);
            Console.Write("Doan [{0},{1}] co gia tri bang : ",vitridau,vitricuoi);
            inMang(a, vitridau, vitricuoi);
        }

        public static void nhapsayso(ref int[] day)
        {
            int n;
            Console.Write("Nhap so phan tu n: ");
            n = int.Parse(Console.ReadLine());
            day = new int[n]; 

            for(int i=0; i<day.Length; i++)
            {
                Console.Write("nhap phan tu thu {0}: ", i);
                day[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void inMang(int[] day, int vitridau, int vitricuoi)
        {
            for(int i = vitridau; i <= vitricuoi; i++)
            {
                Console.Write(day[i]+" ,");
            }
        }

        public static void timtong(int[] day, out int vitridau, out int vitricuoi)
        {
            int k;
            int max = 0;
            vitridau = vitricuoi = 0;
            Console.Write("Nhap k: ");
            k = int.Parse(Console.ReadLine());
            for(int i = 0;i < day.Length ; i++)
            {
                int tong = 0;
                for(int j = i+1;j<day.Length ; j++)
                {
                    tong += day[j];
                    if (tong == k)
                    {
                        int dodai = j - i + 1;

                        if (dodai > max)
                        {
                            max = dodai;
                            vitridau = i;
                            vitricuoi = j;
                        }
                    }
                }
            }
        }
        
    }
}
