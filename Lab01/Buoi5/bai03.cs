using System;

namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            double a;

            do
            {
                Console.Write("Moi ban nhap so a (a > 0): ");
                a=double.Parse(Console.ReadLine()!);
            } while(a<=0);

            double epsilon;

            do
            {
                Console.Write("Moi ban nhap sai so epsilon (0 < epsilon <= 0.1): ");
                epsilon=double.Parse(Console.ReadLine()!);
            } while(epsilon<=0||epsilon>0.1);

            double S=0;
            int n=0;

            while(1.0/(a+n)>=epsilon)
            {
                S+=1.0/(a+n);
                n++;
            }

            Console.WriteLine($"Gia tri cua bieu thuc S(a = {a}, epsilon = {epsilon}) = {S}");
        }
    }
}