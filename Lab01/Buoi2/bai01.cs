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
            Console.Write("Moi ban nhap so a, b: ");

            // Đọc một dòng, cắt chuỗi dựa trên khoảng trắng để lấy a và b
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            // Áp dụng công thức tổng từ 1 đến n là: n * (n + 1) / 2
            int tongB = b * (b + 1) / 2;
            int tongA_1 = (a - 1) * a / 2;

            // Tổng các số trong đoạn [a, b]
            int tongDoan = tongB - tongA_1;

            Console.WriteLine("Tong cua cac so trong doan[" + a + ", " + b + "] la " + tongDoan + ".");
        }
    }
}