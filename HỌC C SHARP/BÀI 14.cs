using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_14
    {
        static void Main(string[] args)
        {
            //1. Khai báo
            char ch1 = 'a'; //Khai báo bắt buộc dùng nháy đơn
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());

            // Cách 2
            char ch2 = (char)64; //dựa theo bảng mã ASCII
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());

            // Ép kiểu char cho kiểu dữ liệu nhập vào
            char ch3 = char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

            // Chuyển đổi kiểu dữ liệu
            char ch4=Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            // So sánh 2 ký tự (Compare)
            char ch5 = 'a'; //97 (mã ASCII)
            char ch6 = 'b'; //98
            char ch7 = 'm'; //109
            Console.WriteLine(ch5.CompareTo(ch6));
            Console.WriteLine(ch6.CompareTo(ch5));
            Console.WriteLine(ch7.CompareTo(ch6));

            // So sánh 2 ký tự (Equals) => trả về True, False
            Console.WriteLine(ch5.Equals(ch7));
            Console.WriteLine(ch5.Equals(ch1));

            Console.WriteLine("                    ");

            // Các phương thức - Char method in C#
            Console.WriteLine(Char.IsDigit('e')); //chữ số
            Console.WriteLine(Char.IsLetter('A')); //chữ cái
            Console.WriteLine(Char.IsWhiteSpace(' ')); //khoảng trắng
            Console.WriteLine(Char.IsLower('a')); //ký tự viết thường
            Console.WriteLine(Char.IsUpper('U')); //ký tự viết hoa

            Console.WriteLine(Char.ToLower('U')); //chuyển sang ký tự viết thường
            Console.WriteLine(Char.ToUpper('n')); //chuyển sang ký tự viết hoa

        }
    }
}
