
/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_11
    {
        public static void Main()
        {
            bai11_3_2();
        }

        // 1. lệnh for
        // xuất các số chẵn từ 0-10 và tính tổng
        public static void bai11_1()
        {
            int tong = 0;
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("i = " + i);
                tong += i;
                Console.WriteLine("tong = " + tong);
            }
            Console.ReadLine();
        }

        // 2. lệnh foreach
        public static void bai11_2_1()
        {
            string[] lst = { "haha", "hehe", "hihi", "keke" }; // khởi tạo 1 list
            foreach (string i in lst)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }

        // làm lại bài Csharp07: nhập vào tháng, in ra số ngày trong tháng đó
        public static void bai11_2_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("Nhập vào 1 tháng: ");
            thang = int.Parse(Console.ReadLine());
            int[] lst = { 1, 3, 5, 7, 8, 10, 12 };
            foreach (int i in lst)
            {
                Console.WriteLine("i=" + i);
                if (thang == i)
                {
                    Console.WriteLine("Tháng bạn vừa nhập có 31 ngày");
                    break;
                }
            }
            Console.ReadLine();
        }

        // 3. continue, break
        // tính tổng các số từ 1-5 nhưng ko bao gồm số 3 (1+2+4+5)
        public static void bai11_3_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    continue; // nếu i=3 thì bỏ qua
                else
                {
                    Console.WriteLine("i = " + i);
                    tong += i;
                }
            }
            Console.WriteLine($"Tổng cần tìm là {tong}");
            Console.ReadLine();
        }

        // tính tổng các số từ 1-5 nhưng chỉ tính đến 3 và thoát chương trình
        public static void bai11_3_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    break; // nếu i=3 thì ko cộng nữa
                else
                {
                    Console.WriteLine("i = " + i);
                    tong += i;
                }
            }
            Console.WriteLine($"Tổng cần tìm là {tong}");
            Console.ReadLine();
        }
    }
} */
