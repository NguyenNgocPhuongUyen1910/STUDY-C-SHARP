using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_4
    {
        public static void Main()
        {

        }
        // CÁC PHÉP SO SÁNH
        public static void so_sanh()
        {
            int n;
            Console.Write("Nhap so n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban vua nhap so {0}", n);
            if (n % 2 == 0)
                Console.WriteLine("so {0} la so chan", n);
            else
                Console.WriteLine("so {0} la so le", n);

            /* if (n % 2 != 0)
                 Console.WriteLine("so {0} la so le", n);
             else
                 Console.WriteLine("so {0} la so chan", n); */

            Console.ReadKey();
        }

        //TOÁN TỬ GÁN (ĐỂ CODE NGẮN GỌN HƠN)
        public static void gan()
        {
        float x, y;
        x = 5;
        y = 9;
        Console.WriteLine("x=" +x);
        x += y; // x=x+y
        /* x -= y; // x=x-y
        x *= y; // x=x*y
        x /= y; // x=x/y
        x %= y; // x=x%y */

        Console.WriteLine("x=" +x);
        Console.ReadKey();
    }
}
}
