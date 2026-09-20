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
            Console.Write("Moi ban nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int tong = 0;
            string chuoiUocSo = "";

            // Duyệt các ước tự nhiên từ 1 đến n/2 (không kể chính nó)
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;

                    // Ghép chuỗi các ước số dạng: 1 + 2 + 3
                    if (chuoiUocSo == "")
                    {
                        chuoiUocSo += i;
                    }
                    else
                    {
                        chuoiUocSo += " + " + i;
                    }
                }
            }

            // Kiểm tra điều kiện tổng các ước bằng n (và n phải lớn hơn 0)
            if (tong == n && n > 0)
            {
                Console.WriteLine(n + " = " + chuoiUocSo + " la so hoan hao.");
            }
            else
            {
                Console.WriteLine(n + " khong la so hoan hao.");
            }
        }
    }
}