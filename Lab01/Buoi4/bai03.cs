using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai03
    {
        // Hàm kiểm tra năm nhuận
        private static bool LaNamNhuan(int nam)
        {
            return (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);
        }

        // Hàm lấy số ngày tối đa của một tháng trong năm
        private static int SoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return LaNamNhuan(nam) ? 29 : 28;
                default:
                    return 31;
            }
        }

        public static void xuly()
        {
            Console.Write("Moi ban nhap ngay, thang, nam: ");

            // Đọc và tách ngày, tháng, năm từ một dòng nhập
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int ngay = int.Parse(input[0]);
            int thang = int.Parse(input[1]);
            int nam = int.Parse(input[2]);

            int ngayKe = ngay + 1;
            int thangKe = thang;
            int namKe = nam;

            // Kiểm tra nếu ngày vượt quá số ngày tối đa của tháng hiện tại
            if (ngayKe > SoNgayTrongThang(thang, nam))
            {
                ngayKe = 1;      // Sang ngày 1 của tháng mới
                thangKe++;       // Tăng tháng

                if (thangKe > 12)
                {
                    thangKe = 1; // Sang tháng 1 của năm mới
                    namKe++;     // Tăng năm
                }
            }

            Console.WriteLine("Ngay sau ngay " + ngay + "/" + thang + "/" + nam + " la ngay " + ngayKe + "/" + thangKe + "/" + namKe + ".");
        }
    }
}