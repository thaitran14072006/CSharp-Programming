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

			int[] mang = new int[n];

			// Nhập các phần tử của mảng
			for (int i = 0; i < n; i++)
			{
				Console.Write("Phan tu " + i + ": ");
				mang[i] = int.Parse(Console.ReadLine());
			}

			// In ra dãy số vừa nhập
			Console.Write("Day so co " + n + " phan tu ");
			for (int i = 0; i < n; i++)
			{
				Console.Write(mang[i] + (i < n - 1 ? " " : ""));
			}
			Console.WriteLine();

			// Xử lý tìm số chẵn, tính tổng và số lượng
			int demChan = 0;
			int tongChan = 0;
			string chuoiSoChan = "";

			for (int i = 0; i < n; i++)
			{
				// Kiểm tra số chẵn (chia hết cho 2)
				if (mang[i] % 2 == 0)
				{
					demChan++;
					tongChan += mang[i];
					if (chuoiSoChan == "")
					{
						chuoiSoChan += mang[i];
					}
					else
					{
						chuoiSoChan += " " + mang[i];
					}
				}
			}

			// In kết quả phần dãy số chẵn
			Console.WriteLine("* Day so chan");
			if (demChan > 0)
			{
				double trungBinhCong = (double)tongChan / demChan;
				// Định dạng trung bình cộng lấy 2 chữ số thập phân (ví dụ: 3.33)
				Console.WriteLine("Day so co " + demChan + " so chan: " + chuoiSoChan + " voi tong la " + tongChan + ", trung binh cong la " + trungBinhCong.ToString("0.02") + ".");
			}
			else
			{
				Console.WriteLine("Day so khong co so chan nào.");
			}
		}
	}
}