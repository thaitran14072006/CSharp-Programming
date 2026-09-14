using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            double epsilon;
            double pi = 0;
            int n = 0;

            Console.Write("Moi ban nhap do sai so epsilon: ");
            epsilon = double.Parse(Console.ReadLine());

            while (4.0 / (2 * n + 1) >= epsilon)
            {
                if (n % 2 == 0)
                {
                    pi += 4.0 / (2 * n + 1);
                }
                else
                {
                    pi -= 4.0 / (2 * n + 1);
                }

                n++;
            }

            double saiSoThucTe = Math.Abs(Math.PI - pi);

            Console.WriteLine("So pi tinh den do chinh xac {0} la: {1}", epsilon, pi);
            Console.WriteLine("Do sai so thuc te la: {0}", saiSoThucTe);
        }
    }
}