using System; 
//cho phep su dung thu vien System
namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            //nhap gio
            Console.Write("Nhap so gio:");
            int h=int.Parse(Console.ReadLine()!);
            
            //nhap phut
            Console.Write("Nhap so phut:");
            int m=int.Parse(Console.ReadLine()!);

            //nhap giay
            Console.Write("Nhap so giay:");
            int s=int.Parse(Console.ReadLine()!);
            
            //tong giay
            int tong=h*3600+m*60+s;

            //in ra ket qua
            Console.WriteLine("Tong so giay cua " + h + ":" + m + ":" + s + " la "+ tong+ " giay");

        }

    }
}
