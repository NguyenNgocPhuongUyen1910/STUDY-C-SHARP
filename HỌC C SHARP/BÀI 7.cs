
/*
namespace HỌC_C_SHARP
{
    internal class BÀI_7
    {
        public static void Main()
        {
            bai7_2();
        }
        // lệnh if - else
        public static void bai7_1()
        {
            float diemTN;
            Console.WriteLine("Nhap diem tot nghiep: ");
            diemTN = float.Parse(Console.ReadLine());
            if(diemTN > 7)
                Console.WriteLine("Diem tot nghiep cua ban la {0} , ban da dau", diemTN);
            // Khối lệnh thì trình bày như này
            if (diemTN > 7)
            {
                Console.WriteLine("Diem tot nghiep cua ban la {0} , ban da dau", diemTN);
                Console.WriteLine("day la dong lenh 2");
                Console.WriteLine("day la dong lenh 3");
            } 
            else Console.WriteLine("Diem tot nghiep cua ban la {0} , ban da tach", diemTN);
            Console.ReadLine();
        }

        // lệnh if - else if - else
        nhập vào điểm trung bình và kết quả xếp loại của học sinh theo tiêu chuẩn sau:
         - Giỏi: nếu điểm kq >=8
         - Khá: nếu 8 > điểm kq >= 6.5
         - Trung bình: nếu 6.5 > điểm kq >= 5
         - Yếu: nếu điểm kq < 5 
        public static void bai7_2()
        {
            float dtb;
            Console.WriteLine("Nhap diem trung binh: ");
            dtb = float.Parse(Console.ReadLine());
            if (dtb >= 8)
                Console.WriteLine("xep loai Gioi");
            else if (dtb >= 6.5 && dtb < 8)
                Console.WriteLine("xep loai Kha");
            else if (dtb >= 5 && dtb < 6.5)
                Console.WriteLine("xep loai Trung binh");
            else
                Console.WriteLine("xep loai Yeu");
            Console.ReadLine() ;
        }

    }
}
*/
