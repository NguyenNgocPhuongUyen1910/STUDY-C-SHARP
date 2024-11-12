using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_5
    {
        //BÀI TẬP TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN
            static void Main(string[] args)
            {
                float r, cv, dt;
                const float PI = 3.14f;
                Console.Write("Nhap ban kinh cua duong tron:");
                r = float.Parse(Console.ReadLine());
                cv = 2 * r * PI;
                dt = r * r * PI;
                Console.WriteLine("Chu vi hinh tron la {0}", cv);
                Console.WriteLine("Dien tich hinh tron la {0}", dt);
                Console.ReadKey();
            }
     
    }
}
