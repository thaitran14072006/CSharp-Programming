using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public static class bai01
    {
        public static void xuly()
        {
            float T, L, H, DTB;
            Console.Write("Nhap diem Toan: ");
            T = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Ly: ");
            L = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            H = float.Parse(Console.ReadLine());
            DTB = (T * 2 + L * 3 + H) / 6;

            if (DTB >= 8 && DTB <= 10)
            {
                Console.Write("Ban co diem trung binh la " + DTB);
                Console.WriteLine(" Xep loai GIOI.");
            }
            else if (DTB < 8 && DTB >= 6.5)
            {
                Console.Write("Ban co diem trung binh la " + DTB);
                Console.WriteLine(" Xep loai KHA.");
            }
            else if (DTB >= 5 && DTB < 6.5)
            {
                Console.Write("Ban co diem trung binh la " + DTB);
                Console.WriteLine(" Xep loai TRUNG BINH.");
            }
            else
            {
                Console.Write("Ban co diem trung binh la " + DTB);
                Console.WriteLine(" Xep loai Yeu.");
            }

        }
    }
}
