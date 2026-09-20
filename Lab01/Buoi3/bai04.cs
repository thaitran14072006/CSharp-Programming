using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai04
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap vao thang: ");
            int thang = int.Parse(Console.ReadLine());

            string tenThang = "";

            switch (thang)
            {
                case 1: tenThang = "January"; break;
                case 2: tenThang = "February"; break;
                case 3: tenThang = "March"; break;
                case 4: tenThang = "April"; break;
                case 5: tenThang = "May"; break;
                case 6: tenThang = "June"; break;
                case 7: tenThang = "July"; break;
                case 8: tenThang = "August"; break;
                case 9: tenThang = "September"; break;
                case 10: tenThang = "October"; break;
                case 11: tenThang = "November"; break;
                case 12: tenThang = "December"; break;
                default:
                    tenThang = "khong xac dinh (vui long nhap tu 1-12)";
                    break;
            }

            if (thang >= 1 && thang <= 12)
            {
                Console.WriteLine("Tieng anh cua thang " + thang + " la " + tenThang + ".");
            }
            else
            {
                Console.WriteLine("Thang nhap vao khong hop le!");
            }
        }
    }
}