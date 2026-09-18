using System;

namespace console
{
    public static class bai04
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap thang: ");
            int thang = int.Parse(Console.ReadLine()!);

            if (thang >= 1 && thang <= 3)
            {
                Console.WriteLine("Thang " + thang + " thuoc qui 1.");
            }
            else if (thang >= 4 && thang <= 6)
            {
                Console.WriteLine("Thang " + thang + " thuoc qui 2.");
            }
            else if (thang >= 7 && thang <= 9)
            {
                Console.WriteLine("Thang " + thang + " thuoc qui 3.");
            }
            else if (thang >= 10 && thang <= 12)
            {
                Console.WriteLine("Thang " + thang + " thuoc qui 4.");
            }
            else
            {
                Console.WriteLine("Thang khong hop le.");
            }
        }
    }
}