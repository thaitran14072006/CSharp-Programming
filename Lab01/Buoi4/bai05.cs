using System;
namespace console;

public  static class bai05
{
    public static void xuly()
    {
        Console.Write("Moi ban nhap so n: ");
        int n = int.Parse(Console.ReadLine());

        int a = n / 1000;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;

        // (a) Kiểm tra số đối xứng
        if (a == d && b == c)
            Console.WriteLine($"{n} la so doi xung.");
        else
            Console.WriteLine($"{n} khong la so doi xung.");

        // (b) Kiểm tra có 3 chữ số giống nhau
        if (a == b && b == c ||
            a == b && b == d ||
            a == c && c == d ||
            b == c && c == d)
            Console.WriteLine($"{n} co 3 chu so giong nhau.");
        else
            Console.WriteLine($"{n} khong co 3 chu so giong nhau.");

        // (c) Kiểm tra có 4 chữ số khác nhau
        if (a != b && a != c && a != d &&
            b != c && b != d &&
            c != d)
            Console.WriteLine($"{n} co 4 chu so khac nhau.");
        else
            Console.WriteLine($"{n} khong co 4 chu so khac nhau.");
    }
}