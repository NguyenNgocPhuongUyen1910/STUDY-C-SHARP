
/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_9
    {
        public static void Main()
        {
            bai9_BT();
        }

        // switch case
        // nhập vào 1 số, kiểm tra chẵn hay lẻ, dùng switch case
        public static void bai9_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập số a: ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;

            switch (div)
            {
                case 0:
                    Console.WriteLine($"Số {a} là số chẵn");
                    break;
                default:
                    Console.WriteLine($"Số {a} là số lẻ");
                    break;
            }
            Console.ReadLine();
        }

        // thay màu text hiển thị
        public static void bai9_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan; // đổi màu chữ
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;  // đổi màu background
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giá");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo tiêu đề");

            Console.ReadLine() ;
        }

        // Bài tập Csharp11: Áp dụng switch case
        // Viết chương trình khung tìm kiếm: cho người dùng nhập vào lựa chọn
        // 1. tìm theo tên
        // 2. tìm theo tác giả
        // 3. tìm theo nhà xuất bản
        // 4. tìm theo tiêu đề
        // Thoát nếu phím bấm không hợp lệ
        public static void bai9_BT()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            Console.WriteLine("1. Tìm theo tên");
            Console.WriteLine("2. Tìm theo tác giả");
            Console.WriteLine("3. Tìm theo nhà xuất bản");
            Console.WriteLine("4. Tìm theo tiêu đề");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    Console.WriteLine("1. Tìm theo tên");
                    break;
                case 2:
                    Console.WriteLine("2. Tìm theo tác giả");
                    break;
                case 3:
                    Console.WriteLine("3. Tìm theo nhà xuất bản");
                    break;
                case 4:
                    Console.WriteLine("4. Tìm theo tiêu đề");
                    break;
                default: 
                    Console.WriteLine("Phím bấm không hợp lệ");
                    break ;
            }
            Console.ReadLine();
        }
    }
} */
