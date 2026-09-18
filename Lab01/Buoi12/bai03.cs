
using System;

namespace console
{
    public static class bai03
    {
        public static void xuly()
        {
            int n, m;

            Console.Write("Nhap so dong: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot: ");
            m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool toanLe = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        toanLe = false;
                        break;
                    }
                }

                if (!toanLe)
                    break;
            }

            if (toanLe)
                Console.WriteLine("Ma tran A toan le!");
            else
                Console.WriteLine("Ma tran A khong toan le!");
        }
    }
}
