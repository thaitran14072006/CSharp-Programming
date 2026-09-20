using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai03
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            double[] mang = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + i + ": ");
                double x = double.Parse(Console.ReadLine());

                // Thuật toán chèn trực tiếp (Insertion-on-the-fly) ngay khi nhập
                int j = i - 1;
                while (j >= 0 && mang[j] > x)
                {
                    mang[j + 1] = mang[j]; // Dời các phần tử lớn hơn sang phải
                    j--;
                }
                mang[j + 1] = x; // Chèn phần tử mới vào đúng vị trí tăng dần
            }

            // In ra dãy số sau khi nhập xong để kiểm tra kết quả
            Console.Write("Day so sau khi nhap tang dan (" + n + " phan tu):");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + mang[i]);
            }
            Console.WriteLine();
        }
    }
}