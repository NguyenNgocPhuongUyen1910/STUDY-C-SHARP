// Toán tử 3 ngôi
/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_8
    {
        // nhập vào 1 số n, kiểm tra n là số chẵn hay lẻ
        public static void Main()
        {
            bai8_BT();
        }
        public static void bai8()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào số n: ");
            n = int.Parse(Console.ReadLine());
            string traLoi = (n % 2 == 0) ? "số chẵn" : "số lẻ";
            Console.WriteLine($"Số {n} là {traLoi}");
            Console.ReadLine();
        }

        // Bài tập Csharp10: Viết chương trình nhập vào điểm trung bình, và kết quả xếp loại của học sinh (dùng toán tử 3 ngôi )
        public static void bai8_BT()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float dtb;
            Console.WriteLine("Nhập điểm trung bình của bạn: ");
            dtb = float.Parse(Console.ReadLine());
            // biến = biểu thức 1 ? biểu thức 2 : biểu thức 3
            string kq = (dtb >= 8) ? "Giỏi" : ((dtb >= 6.5 && dtb < 8) ? "Khá" : (dtb >= 5 && dtb < 6.5) ? "Trung bình" : "Yếu");
            Console.WriteLine($"Điểm trung bình của bạn là {dtb}, bạn xếp loại {kq}");
            Console.ReadLine();
        }
    }
} */
