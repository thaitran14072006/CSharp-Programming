using System;
namespace console
{
    public static class bai04
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap ba so thuc a, b, c: ");

            double[] num=Array.ConvertAll(
                Console.ReadLine()!.Split(),
                double.Parse
            );

            double a=num[0];
            double b=num[1];
            double c=num[2];

            // Kiem tra co tao thanh tam giac khong
            if(a<=0||b<=0||c<=0||a+b<=c||a+c<=b||b+c<=a)
            {
                Console.WriteLine($"Ba so ({a}, {b}, {c}) khong tao thanh duoc tam giac.");
                return;
            }

            Console.WriteLine($"Ba so ({a}, {b}, {c}) tao thanh duoc tam giac.");

            // Kiem tra tam giac deu
            bool deu=a==b&&b==c;

            // Kiem tra tam giac can
            bool can=a==b||a==c||b==c;

            // Tim canh lon nhat
            double lonNhat=Math.Max(a,Math.Max(b,c));

            // Kiem tra tam giac vuong
            bool vuong;

            if(lonNhat==a)
                vuong=a*a==b*b+c*c;
            else if(lonNhat==b)
                vuong=b*b==a*a+c*c;
            else
                vuong=c*c==a*a+b*b;

            // Phan loai tam giac
            if(deu)
                Console.WriteLine("Tam giac tao thanh la tam giac deu.");
            else if(vuong&&can)
                Console.WriteLine("Tam giac tao thanh la tam giac vuong can.");
            else if(vuong)
                Console.WriteLine("Tam giac tao thanh la tam giac vuong.");
            else if(can)
                Console.WriteLine("Tam giac tao thanh la tam giac can.");
            else
                Console.WriteLine("Tam giac tao thanh la tam giac thuong.");
        }
    }
}