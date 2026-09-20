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
			Console.Write("Moi nhap so thuc a: ");
			double a = double.Parse(Console.ReadLine());

			double tong = 0.0;
			int n = 0;

			// Vòng lặp sẽ tiếp tục cộng dồn miễn là tổng vẫn nhỏ hơn hoặc bằng a
			while (tong <= a)
			{
				n++;
				// Phải dùng 1.0 (số thực) để phép chia không bị mất phần thập phân
				tong += 1.0 / n;
			}

			Console.WriteLine("So nguyen duong n be nhat thoa man la: " + n);
		}
	}
}