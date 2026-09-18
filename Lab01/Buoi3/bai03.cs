using System;

namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap he so a, b, c: ");
            double a = double.Parse(Console.ReadLine()!);
            double b = double.Parse(Console.ReadLine()!);
            double c = double.Parse(Console.ReadLine()!);

            // Truong hop a = 0
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co 1 nghiem, x = " + x);
                }
            }
            else
            {
                // Tinh delta
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep, x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Phuong trinh co 2 nghiem, x1 = " 
                        + x1 + ", x2 = " + x2);
                }
            }
        }
    }
}