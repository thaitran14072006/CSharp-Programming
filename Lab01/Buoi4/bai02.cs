using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai02
    {
        public static void xuly()
        {
            float SNT, SNN, TT, Tien;

            Console.Write("Moi nhap so nuoc tieu thu thang truoc: ");
            SNT = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap so nuoc tieu thu thang nay: ");
            SNN = float.Parse(Console.ReadLine());
            TT = SNN - SNT;

            if (TT <= 4)
            {
                Tien = TT * 4400;
                Console.WriteLine("So tien phai tra cho " + TT + " m^3 nuoc la " + Tien);
            }
            else if (TT <= 6)
            {
                Tien = 4 * 4400 + (TT - 4) * 8300;
                Console.WriteLine("So tien phai tra cho " + TT + " m^3 nuoc la " + Tien);
            }
            else
            {
                Tien = 4 * 4400 + 2 * 8300 + (TT - 6) * 10500;
                Console.WriteLine("So tien phai tra cho " + TT + " m^3 nuoc la " + Tien + "Đ");
            }


        }
    }
}
