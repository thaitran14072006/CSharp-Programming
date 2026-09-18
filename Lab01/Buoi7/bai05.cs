using System;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            int n=int.Parse(Console.ReadLine()!);

            Console.Write("Moi ban nhap vi tri k: ");
            int k=int.Parse(Console.ReadLine()!);

            string so=Math.Abs(n).ToString();

            // (a) Tim chu so thu k tinh tu trai
            int chuSo=so[k-1]-'0';

            // (b) Tinh tong cac chu so le
            int tong=0;

            // (c) Tim chu so le nho nhat va lon nhat
            int minLe=10;
            int maxLe=-1;

            for(int i=0;i<so.Length;i++)
            {
                int x=so[i]-'0';

                if(x%2!=0)
                {
                    tong+=x;

                    if(x<minLe)
                        minLe=x;

                    if(x>maxLe)
                        maxLe=x;
                }
            }

            Console.WriteLine($"Chu so o vi tri {k} (tinh tu trai) cua {n} la {chuSo}.");
            Console.WriteLine($"Tong cac chu so le cua {n} la {tong}.");
            Console.WriteLine($"{n} co chu so le nho nhat la {minLe} va lon nhat la {maxLe}.");
        }
    }
}