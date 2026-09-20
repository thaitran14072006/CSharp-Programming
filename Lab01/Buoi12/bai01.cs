using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai01
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];

            // Nhập các phần tử cho ma trận
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Phan tu [" + i + ", " + j + "]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // In lại cấu trúc ma trận để kiểm tra
            Console.WriteLine("Mang co " + n + " dong x " + m + " cot:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + (j < m - 1 ? " " : ""));
                }
                Console.WriteLine();
            }

            int tongChan = 0;
            int tongLe = 0;

            // Duyệt toàn bộ ma trận để tính tổng chẵn, lẻ
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        tongChan += A[i, j];
                    }
                    else
                    {
                        tongLe += A[i, j];
                    }
                }
            }

            // Xuất kết quả theo đúng định dạng mẫu
            Console.WriteLine("Tong cac so chan la " + tongChan + " va tong so le la " + tongLe + ".");
        }
    }
}