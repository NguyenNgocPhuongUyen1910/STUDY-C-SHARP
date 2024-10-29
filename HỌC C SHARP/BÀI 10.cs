

/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_10
    {
        public static void Main()
        {
            bai10_3();
        }

        // 1. lệnh while
        public static void bai10_1()
        {
            int x = 0;
            while (x<=5)
            {
                Console.WriteLine("x=" + x);
                x++; // x=x+1
            }
            Console.ReadLine();
        }

        // 1.1. Ví dụ thực hành: Viết chương trình nhập vào số n từ bàn phím.
        // n phải nằm trong khoảng từ 1 đến 99
        // Nhập sai bắt nhập lại
        public static void bai10_1_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào số nguyên n từ 1-99: ");
            n = int.Parse(Console.ReadLine());

            while (n<1 || n>99)
            {
                Console.WriteLine("Nhập lại n, n chỉ được từ 1-99");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bạn đã nhập thành công giá trị n, n= " +n);
            Console.ReadLine();
        }

        // 2. do while
        // tính tổng từ 1-5
        public static void bai10_2()
        {
            Console.OutputEncoding=Encoding.UTF8;
            int a = 1;
            int tong = 0;
            do
            {
                tong += a; //tong=tong+a
                a++;
            }
            while (a <= 5);
            Console.WriteLine("Tổng từ 1-5 là {0}", tong);
            Console.ReadLine() ;
        }

        // 3. while true - vòng lặp vô hạn (nếu ko có lệnh dừng)
        public static void bai10_3()
        {
            int n = 0;
            while(true)
            {
                n++;
                Console.WriteLine("n="+n);
                if (n == 100)
                    break;
            }
            Console.ReadLine();
        }
    }
} */
