using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai05
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            double[] mang = new double[n];

            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu " + i + ": ");
                mang[i] = double.Parse(Console.ReadLine());
            }

            // In ra dãy số vừa nhập theo định dạng mẫu
            Console.Write("Day so co " + n + " phan tu:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + mang[i]);
            }
            Console.WriteLine();

            // Biến lưu thông tin đoạn dương dài nhất
            int maxLen = 0;
            int bestStart = -1;
            int bestEnd = -1;

            int idx = 0;
            while (idx < n)
            {
                // Bỏ qua các số không dương (<= 0)
                while (idx < n && mang[idx] <= 0)
                {
                    idx++;
                }

                if (idx >= n) break;

                // Xác định điểm bắt đầu của đoạn số dương
                int start = idx;
                int end = start;

                // Tìm điểm kết thúc của đoạn số dương liên tiếp
                while (end < n && mang[end] > 0)
                {
                    end++;
                }
                end--; // Lùi lại phần tử dương cuối cùng trong đoạn

                // Tính độ dài đoạn hiện tại
                int currentLen = end - start + 1;

                // Cập nhật nếu tìm thấy đoạn dài hơn
                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                    bestStart = start;
                    bestEnd = end;
                }

                idx = end + 1;
            }

            // In kết quả
            if (maxLen > 0)
            {
                Console.Write("Doan duong [" + bestStart + ", " + bestEnd + "] dai nhat:");
                for (int i = bestStart; i <= bestEnd; i++)
                {
                    Console.Write(" " + mang[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Day so khong co so duong nao.");
            }
        }
    }
}