using System;

namespace console
{
    public static class bai01
    {
        public static void xuly()
        {
            Console.Write("Moi ban nhap do cao h: ");
            int h=int.Parse(Console.ReadLine()!);

            for(int i=0;i<h;i++)
            {
                // In chu F
                for(int j=0;j<3;j++)
                {
                    if(i==0||j==0||(i==h/2&&j<3))
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.Write("    ");

                // In chu H
                for(int j=0;j<h;j++)
                {
                    if(j==0||j==h-1||i==h/2)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.Write("    ");

                // In chu L
                for(int j=0;j<3;j++)
                {
                    if(j==0||i==h-1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.Write("    ");

                // In chu T
                for(int j=0;j<3;j++)
                {
                    if(i==0||j==1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}