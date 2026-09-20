using System;

namespace console;

public static class bai02
{
    public static void xuly()
    {
        double R, S, P;
        const double PI = 3.14;

        Console.Write("Nhap ban kinh R: ");
        R = double.Parse(Console.ReadLine());

        S = PI * R * R;
        P = 2 * PI * R;

        Console.WriteLine("Dien tich S = {0:F1}", S);
        Console.WriteLine("Chu vi P = {0:F1}", P);
    }
}