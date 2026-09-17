using System;
namespace console
{
    public static class bai01
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap 5 so a, b, c, d, e: ");

            int[] num=Array.ConvertAll( //nhan kq kieu int
                Console.ReadLine()!.Split(), //nhap chuoi (dang string), tach chuoi
                int.Parse //chuyen ve kieu int
            );
            int max= num[0];
            int min= num[0];
            for(int i = 1; i < 5; i++)
            {
                if (num[i] > max)
                {
                    max=num[i];
                }
                if (num[i] < min)
                {
                    min=num[i];
                }
            }
            Console.WriteLine($"Gia tri lon nhat cua {num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]} la {max}");
            Console.WriteLine($"Gia tri nho nhat cua {num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]} la {min}");
        }
    }
}