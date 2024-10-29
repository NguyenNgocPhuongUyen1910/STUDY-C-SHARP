
/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_11_BT
    {
        public static void Main()
        {
            Csharp18();
        }

        // Bài tập Csharp12: Viết chương trình nhập vào số nguyên n, in ra kết quả n! (giai thừa của n)
        // Dùng vòng lặp for 
        public static void Csharp12_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int gt = 1;
            Console.WriteLine("Nhập số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("i=" + i);
                gt = gt * i;
            }
            Console.WriteLine($"Giai thừa của n là {gt}");
            Console.ReadLine();
        }

        // Dùng vòng lặp while
        public static void Csharp12_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int i = 1;
            int gt = 1;
            Console.WriteLine("Nhập số nguyên n: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                gt = gt * i;
                i++;
            }
            Console.WriteLine($"Kết quả {n}! = {gt}");
            Console.ReadLine();
        }
    

        // Bài tập Csharp13: Viết chương trình nhập số a từ bàn phím
        // Nếu a chẵn thì tính tổng các số chẵn từ 0 đến a
        // Nếu a lẻ thì in ra dòng chữ “tôi o tính tổng số lẻ, bye bye ” và thoát chương trình
        public static void Csharp13()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            int tong = 0;
            Console.WriteLine("Nhập số nguyên a: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 != 0)
                Console.WriteLine("Tôi không tính tổng số lẻ,  bye bye");
            else
            {
                for (int i = 0; i <= a; i += 2)
                {
                    tong += i;
                }
                Console.WriteLine($"Tổng các số chẵn từ 0 đến {a} là {tong}");    
            }
            Console.ReadLine();
        }


        //Bài tập Csharp14: Viết chương trình tính tổng các số lẻ từ 1 đến n, n nhập từ bàn phím
        //Nhập n = 7, Bỏ qua không cộng tổng với số 3 => in ra kết quả (gợi ý đáp án : 1+5+7 =13)
        public static void Csharp14_1()
        {
            Console.OutputEncoding=Encoding.UTF8;
            int n;
            int tong = 0;
            Console.WriteLine("Nhập số nguyên n");
            n = int.Parse(Console.ReadLine());
            for (int i = 1;i<=n;i+=2)
            {
                if (i == 3)
                    continue;
                else
                tong += i;
            }
            Console.WriteLine($"Đáp án là {tong}");
            Console.ReadLine();
        }

        //Thử break khi vòng lặp chạy đến giá trị n = 3
        public static void Csharp14_2()
        {  
            Console.OutputEncoding=Encoding.UTF8;
            int n;
            int tong = 0;
            Console.WriteLine("Nhập số nguyên n");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                if (i == 3)
                    break;
                else
                tong += i;
            }
            Console.WriteLine($"Đáp án là {tong}");
            Console.ReadLine();
        }


        // Bài tập Csharp15 : Viết chương trình Tìm những số chia hết cho 3 từ 10 đến 50
        public static void Csharp15()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 10; i <= 50; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i+" ");
            }
            Console.ReadLine();
        }


        // Bài tập Csharp16: Viết chương trình : Tính tổng S= 1!+2!+3!+....+10!
        public static void Csharp16()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            int gt = 1;
            for(int i = 1; i <= 10;i++)
            {
                gt *= i;
                Console.WriteLine($"{i}! = {gt}");
                tong += gt;
                Console.WriteLine($"Tổng = {tong}");
            }
            Console.WriteLine($"Vậy: tổng các giai thừa từ 1 đến 10 là {tong}");
            Console.ReadLine();
        }


        // Bài tập Csharp17: Số hoàn thiện (hay còn gọi là số hoàn chỉnh, số hoàn hảo hoặc số hoàn thành)
        // là một số nguyên dương mà tổng các ước nguyên dương chính thức của nó
        // (số nguyên dương bị nó chia hết ngoại trừ nó) bằng chính nó. vd: 6=1+2+3
        // + Tìm tất cả những số hoàn thiện trong phạm vi từ 1-1000

        // để dễ hiểu, bắt đầu làm bài toán kiểm tra xem số n vừa nhập có phải số hoàn hảo không?
        public static void Csharp17_ktraSoHoanHao()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            if (tong == n)
                Console.WriteLine($"{n} là số hoàn hảo");
            else
                Console.WriteLine($"{n} không là số hoàn hảo");
            Console.ReadLine();
        }
        // Giải
        public static void Csharp17_kq()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Số hoàn hảo từ trong dãy 1 đến 1000 là: ");
            for(int n = 1; n <= 1000; n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        tong += i;
                }
             if (tong == n)
                    Console.WriteLine($"{n}");
            }
            Console.ReadLine() ;
        }

        // Bài tập Csharp18: Viết chương trình nhập số nguyên a > 0 từ bàn phím
        // Cho biết đó có phải số ng tố (số ng tố là số >1, và chỉ chia hết cho 1 và chính nó )
        // Kết thúc chương trình hỏi người dùng: Bạn có muốn tiếp tục sử dụng phần mềm không? Nếu chọn không thì thoát ctrinh
        public static void Csharp18()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập số nguyên a > 0: ");
            a = int.Parse(Console.ReadLine());
            // check điều kiện để đảm bảo a > 0
            while (a <= 0)
            {
                Console.WriteLine("Nhập lại a, a phải lớn hơn 0");
                    a = int.Parse(Console.ReadLine());
            }
            // kiểm tra số nguyên tố
            int demUoc = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    demUoc++;
            }
            if(demUoc == 2)
                Console.WriteLine($"{a} là số nguyên tố");
            else
                Console.WriteLine($"{a} không là số nguyên tố");
            Console.ReadLine();
        }
    }
} */
