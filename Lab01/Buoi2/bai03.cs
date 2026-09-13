using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace console
{
    public class bai03
    {
        public static void xuly()
        {
            double x1, x2, x3, fx;
            Console.Write("Moi nhap x: ");
            x1 = double.Parse(Console.ReadLine());
            x2 = x1 * x1;
            x3 = x2 * x1;
            fx = 1 + 2 * x1 + 3 * x2 - 4 * x3;
            Console.WriteLine("f(x) = " + fx);
        }
    }
}
