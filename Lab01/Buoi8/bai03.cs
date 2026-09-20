using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai03
    {
        // Hàm tìm Ước chung lớn nhất (UCLN) bằng thuật toán Euclid
        private static int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static void xuly()
        {
            Console.Write("Moi ban nhap tu so: ");
            int tuSo = int.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap mau so: ");
            int mauSo = int.Parse(Console.ReadLine());

            if (mauSo == 0)
            {
                Console.WriteLine("Mau so khong the bằng 0!");
            }
            else if (tuSo == 0)
            {
                Console.WriteLine("Phan so 0/" + mauSo + " duoc rut gon thanh 0/1.");
            }
            else
            {
                // Tìm UCLN để rút gọn
                int ucln = TimUCLN(tuSo, mauSo);
                int tuRutGon = tuSo / ucln;
                int mauRutGon = mauSo / ucln;

                // Xử lý dấu âm cho mẫu số (nếu mẫu âm thì đưa dấu trừ lên tử)
                if (mauRutGon < 0)
                {
                    tuRutGon = -tuRutGon;
                    mauRutGon = -mauRutGon;
                }

                Console.WriteLine("Phan so " + tuSo + "/" + mauSo + " duoc rut gon thanh " + tuRutGon + "/" + mauRutGon + ".");
            }
        }
    }
}