using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    public static class bai05
    {
        public static void xuly()
        {
            int choice=0;
            do
            {
                Console.WriteLine("THUC DON");
                Console.WriteLine("1. Tinh dien tich tam giac");
                Console.WriteLine("2. Tinh dien tich hinh chu nhat");
                Console.WriteLine("3. Tinh dien tich hinh tron");
                Console.WriteLine("4. Thoat");

                Console.Write("Moi ban chon chuc nang [1, 2, 3, 4]: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ban vua moi chon chuc nang tinh dien tich tam giac");
                        break;

                    case 2:
                        Console.WriteLine("Ban vua moi chon chuc nang tinh dien tic hinh chu nhat");
                        break;

                    case 3:
                        Console.WriteLine("Ban vua moi chon chuc nang tinh dien tich hinh tron");
                        break;

                    case 4:
                        break;
                }


            } while (choice != 4);

        }
    }
}
