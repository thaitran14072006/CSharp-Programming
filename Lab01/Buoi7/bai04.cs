using System;
namespace console;

public static class bai04
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap ngay: ");
        int ngay = int.Parse(Console.ReadLine()!);

        Console.Write("Moi ban nhap thang: ");
        int thang = int.Parse(Console.ReadLine()!);

        Console.Write("Moi ban nhap nam: ");
        int nam = int.Parse(Console.ReadLine()!);

        // Nếu ngày > 1 thì chỉ cần giảm ngày đi 1
        if (ngay > 1)
        {
            ngay--;
        }
        else
        {
            // Ngày = 1 thì phải lùi về tháng trước
            if (thang > 1)
            {
                thang--;
            }
            else
            {
                // 1/1 thì ngày trước là 31/12 của năm trước
                thang = 12;
                nam--;
            }

            // Xác định số ngày của tháng trước
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngay = 30;
            }
            else if (thang == 2)
            {
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    ngay = 29;
                else
                    ngay = 28;
            }
            else
            {
                ngay = 31;
            }
        }

        Console.WriteLine($"Ngay truoc ngay {ngay + (ngay == 0 ? 1 : 0)}/{thang}/{nam} la ngay {ngay}/{thang}/{nam}.");
    }
}