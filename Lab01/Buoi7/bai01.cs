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
            Console.Write("Moi ban nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("h=" + h);

            if (h >= 1)
            {
                // Dòng đầu tiên luôn in 1 dấu sao
                Console.WriteLine("*");

                // Các dòng trung gian từ 2 đến h-1 in "* *"
                for (int i = 2; i < h; i++)
                {
                    Console.WriteLine("* *");
                }

                // Dòng cuối cùng in (2*h - 1) dấu sao cách nhau bởi khoảng trắng (nếu h > 1)
                if (h > 1)
                {
                    string dongCuoi = "";
                    for (int i = 0; i < 2 * h - 1; i++)
                    {
                        dongCuoi += "*";
                        if (i < 2 * h - 2)
                        {
                            dongCuoi += " ";
                        }
                    }
                    Console.WriteLine(dongCuoi);
                }
            }
        }
    }
}