
//SỬA BÀI TẬP
/*
using System.Text;
namespace HỌC_C_SHARP
{
    internal class BÀI_7_1
    {
        public static void Main()
        {
            Csharp_09();
        }

        // Bài tập Csharp04: Tìm x, y khi biết tổng và hiệu 
        // case test : Tong = 14 ,hieu = 4 => x=9, y = 5 
        // case 2 : Tong = 8 hieu = 5 => x=6.5, y = 1.5
        public static void Csharp_04()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double tong, hieu;
            Console.WriteLine("Nhập tổng hai số: ");
            tong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hiệu hai số: ");
            hieu = double.Parse(Console.ReadLine());

            double x = (tong + hieu) / 2;
            double y = tong - x;

            Console.WriteLine("Giá trị của x là {0}", x);
            Console.WriteLine("Giá trị của y là {0}", y);
            Console.ReadLine();
        }

        // Bài tập Csharp05: Viết chương trình nhập vào chiều cao, cân nặng, tính BMI và xuất ra thông báo
        // BMI<15: Thân hình quá gầy
        // BMI>=15 and BMI<16: Thân hình gầy
        // BMI>=16 and BMI<18.5: Thân hình hơi gầy
        // BMI>=18.5 and BMI<25:Thân hình bình thường
        // BMI>=25 and BMI< 30:Thân hình hơi béo
        // BMI >=30 and BMI<35:Thân hình béo
        // BMI >=35:Thân hình quá béo
        // Gợi ý: BMI=canNang/(chieuCao ^2 )

        // viết hàm mũ
        // int x=2;
        // Math.Pow(x,2); x mũ 2

        public static void Csharp_05()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float chieuCao, canNang;
            Console.WriteLine("Nhập chiều cao của bạn (m) ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng của bạn (kg): ");
            canNang = float.Parse(Console.ReadLine());

            double BMI = canNang / (Math.Pow(chieuCao, 2));
            //Console.WriteLine("BMI của bạn là " + BMI);
            Console.WriteLine("BMI của bạn là {0}", Math.Round(BMI, 2)); // làm tròn 2 chữ số thập phân

            if (BMI < 15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else if (BMI >= 30 && BMI < 35)
                Console.WriteLine("Thân hình béo");
            else
                Console.WriteLine("Thân hình quá béo");

            Console.ReadKey();
        }

        // Bài tập Csharp06: Viết chương trình nhập vào 1 năm dương lịch, kiểm tra năm đó có phải năm nhuận hay không.
        // Gợi ý : Năm nhuận là năm (chia hết cho 4, và không chia hết cho 100) hoặc(chia hết cho 400)
        // suy ra ((nam %4 ==0) && (nam %100 !=0)) || (nam %400 ==0)

        // Case test :
        // Năm nhuận : 2004, 2008, 2012, 2016, 2020, 2024
        // Năm không nhuận : 1900, 2005
        public static void Csharp_06()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int nam;
            Console.WriteLine("Nhập vào một năm bất kỳ: ");
            nam = int.Parse(Console.ReadLine());

            if ((nam % 4 == 0) && nam % 100 != 0)
                Console.WriteLine($"Năm {nam} là năm nhuận");
            else
                Console.WriteLine($"Năm {nam} là năm không nhuận");
            Console.ReadKey();
        }

        // Bài tập Csharp07: Viết chương trình cho người dùng nhập vào 1 tháng bất kỳ từ 1 – 12 => Cho biết tháng đó có bao nhiêu ngày ?
        // Gợi ý :
        // - Tháng 1,3,5,7,8,10,12 có 31 ngày
        // - Tháng 4,6,9,11 có 30 ngày
        // _ Nếu tháng 2 thì yêu cầu nhập thêm năm:
        // + nếu năm nhuận thì tháng 2 có 29 ngày
        // + năm không nhuận thì tháng 2 có 28 ngày
        public static void Csharp_07()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("Nhập một tháng bất kỳ: ");
            thang = int.Parse(Console.ReadLine());

            if (thang == 2)
            {
                int nam;
                Console.WriteLine("Vui lòng nhập thêm năm: ");
                nam = int.Parse(Console.ReadLine());
                if ((nam % 4 == 0) && nam % 100 != 0)
                    Console.WriteLine($"Năm {nam} là năm nhuận, nên tháng 2 có 29 ngày");
                else Console.WriteLine($"Tháng 2 năm {nam} có 28 ngày");
            }
            else if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                Console.WriteLine($"Tháng {thang} có 31 ngày");
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                Console.WriteLine($"Tháng {thang} có 30 ngày");
            else
                Console.WriteLine("Tháng bạn nhập không tồn tại");

            Console.ReadKey();
        }

        // Bài tập Csharp08: Viết chương trình giải phương trình bậc 2 : ax^2 + bx + c =0
        // case1 : a=1, b=2, c=-3 suy ra PT có 2 nghiệm x1 = 1 và x2 = -3
        // case2 : a=1, b=2, c=1 suy ra PT có nghiệm kép x1 = x2 = -1 
        // case3 : a=1, b=1, c=1 suy ra PT vô nghiệm
        public static void Csharp_08()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b, c, delta;
            Console.WriteLine("Nhập giá trị của a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị của b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị của c: ");
            c = float.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("Phương trình vô nghiệm");
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine($"Phương trinh có nghiệm kép x = {x}");
            }
            else
            {
                double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm riêng biệt là x1 = {x1} và x2 = {x2}");
            }
            Console.ReadKey();
        }


        // Bài tập Csharp_09: Viết chương trình nhập vào tháng trong năm, cho biết tháng đó thuộc quý mấy
        // Gợi ý : 1 năm có 4 quý, mỗi quý 3 tháng
        // + Quý 1 : tháng 1,2,3
        // + Quý 2 : tháng 4,5,6
        // + Quý 3 : tháng 7,8,9
        // + Quý 4 : tháng 10,11,12
        public static void Csharp_09()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("Nhập vào một tháng bất kỳ: ");
            thang = int.Parse(Console.ReadLine());

            if (thang == 1 || thang == 2 || thang == 3)
                Console.WriteLine($"Tháng {thang} thuộc quý 1");
            else if (thang == 4 || thang == 5 || thang == 6)
                Console.WriteLine($"Tháng {thang} thuộc quý 2");
            else if (thang == 7 || thang == 8 || thang == 9)
                Console.WriteLine($"Tháng {thang} thuộc quý 3");
            else if (thang == 10 || thang == 11 || thang == 12)
                Console.WriteLine($"Tháng {thang} thuộc quý 4");
            else
                Console.WriteLine("Tháng bạn nhập không tồn tại");
            Console.ReadKey();
        }
    }

} */
