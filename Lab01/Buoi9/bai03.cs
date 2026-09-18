using System;

namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so luong phan tu: ");
            int n=int.Parse(Console.ReadLine()!);

            double[] num=new double[n];

            int soAm=0;
            int soKhong=0;
            int soDuong=0;

            for(int i=0;i<n;i++)
            {
                Console.Write($"Phan tu {i}: ");
                num[i]=double.Parse(Console.ReadLine()!);

                if(num[i]<0)
                    soAm++;
                else if(num[i]==0)
                    soKhong++;
                else
                    soDuong++;
            }

            Console.WriteLine($"Day so co {soAm} so am, {soKhong} so khong va {soDuong} so duong.");
        }
    }
}