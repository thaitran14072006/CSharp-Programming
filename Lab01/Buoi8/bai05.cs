using System;

namespace console
{
    public static class bai05
    {
        static string doc3so(int n)
        {
            string[] chuSo={"khong","mot","hai","ba","bon","nam","sau","bay","tam","chin"};

            int tram=n/100;
            int chuc=(n/10)%10;
            int donVi=n%10;

            string kq="";

            if(tram>0)
            {
                kq+=chuSo[tram]+" tram";

                if(chuc==0&&donVi>0)
                    kq+=" le";
            }

            if(chuc>0)
            {
                if(chuc==1)
                    kq+=" muoi";
                else
                    kq+=" "+chuSo[chuc]+" muoi";
            }

            if(donVi>0)
            {
                if(chuc>1&&donVi==1)
                    kq+=" mot";
                else if(chuc>0&&donVi==5)
                    kq+=" lam";
                else
                    kq+=" "+chuSo[donVi];
            }

            return kq.Trim();
        }

        public static void xuly()
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            long n=long.Parse(Console.ReadLine()!);

            long ti=n/1000000000;
            long trieu=(n/1000000)%1000;
            long nghin=(n/1000)%1000;
            long donVi=n%1000;

            string kq="";

            // Nhom ty
            if(ti>0)
                kq+="["+doc3so((int)ti)+" ti]";

            // Nhom trieu
            if(trieu>0)
            {
                if(kq!="")
                    kq+=" ";

                kq+="["+doc3so((int)trieu)+" trieu]";
            }

            // Nhom nghin
            if(nghin>0)
            {
                if(kq!="")
                    kq+=" ";

                if(nghin<100&&trieu>0)
                    kq+="[le "+doc3so((int)nghin)+" ngan]";
                else
                    kq+="["+doc3so((int)nghin)+" ngan]";
            }

            // Nhom don vi
            if(donVi>0)
            {
                if(kq!="")
                    kq+=" ";

                if(donVi<100&&(nghin>0||trieu>0||ti>0))
                    kq+="[le "+doc3so((int)donVi)+"]";
                else
                    kq+="["+doc3so((int)donVi)+"]";
            }

            Console.WriteLine($"So {n:N0} doc thanh: {kq}");
        }
    }
}