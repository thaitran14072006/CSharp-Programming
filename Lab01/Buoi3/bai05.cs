using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            int ngay, thang, nam;
            Console.Write("Moi nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap nam: ");
            nam = int.Parse(Console.ReadLine());

            while (thang > 12 || thang < 1)
            {
                Console.Write("Moi nhap lai thang: ");
                thang = int.Parse(Console.ReadLine());
            }

            if (nam % 4 == 0 || nam % 400 == 0 && nam % 100 != 0)
            {
                switch (thang)
                {
                    case 2:
                        ngay = 29;
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        ngay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        ngay = 30;
                        break;
                    default:
                        ngay = 29;
                        break;
                }
            }
            else
            {
                switch (thang)
                {
                    case 2:
                        ngay = 28;
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        ngay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        ngay = 30;
                        break;
                    default:
                        ngay = 28;
                        break;
                }
            }
            Console.WriteLine("Thang " + thang + " trong nam " + nam + " co " + ngay + " ngay");
        }
    }
}
