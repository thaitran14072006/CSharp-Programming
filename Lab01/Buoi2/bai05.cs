using System ;
namespace console
{
    public static class bai05{
        public static void xuly()
        {
            //nhap so nguyen n
            Console.Write("Moi ban nhap so nguyen n:");
            int n=int.Parse(Console.ReadLine()!);

            //n^278
            long kq=1;
            for(int i = 0; i < 278; i++)
            {
                kq=(kq*n)%100;
            }
            Console.WriteLine($"{n}^278 co hai chu so cuoi cung la {kq}");
        }
    }
}