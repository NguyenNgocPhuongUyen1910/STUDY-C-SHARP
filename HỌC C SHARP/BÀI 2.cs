
/*
namespace HỌC_C_SHARP
{
    internal class BÀI_2
    {
        public static void Main()
        {
            //bai2_1();
        }
        public static void bai2_1()
        {
            //BIẾN TRONG C SHARP
            {
                int soLuong = 0; //khởi tạo biến
                float diemTrungBinh = 8.5f;
                string name = "Uyen";
                byte tuoi; //khai báo biến
                Console.WriteLine("So luong la: {0}", soLuong);
                Console.WriteLine("So luong la: {0},diem trung binh la: {1}", soLuong, diemTrungBinh);
                Console.ReadKey();

            }
        }

        //ÉP KIỂU DỮ LIỆU
        public static void bai2_2()
        {
            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine("Gia tri cua z la:" + z);
            float z2 = (float)a / b; //gán tường minh cho a và b kiểu dữ liệu float
            Console.WriteLine("Gia tri cua z2 la:" + z2);
            Console.ReadKey();
        }

        //VÍ DỤ VẬN DỤNG
        public static void bai2_3()
        {
            string hoTen;
            float diemToan;
            float diemVan;
            Console.WriteLine("Nhap vao ho ten:");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao diem Toan:");
            diemToan = float.Parse(Console.ReadLine()); // ép kiểu dữ liệu
            Console.WriteLine("Nhap vao diem Van:");
            diemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Hoc sinh {0} co diem Toan la {1} va diem Van la {2}", hoTen, diemToan, diemVan);
            Console.ReadLine();
        }

        //NỘI SUY
        public static void bai2_4()
        {
            var y = 199; //kiểm tra kiểu dữ liệu
            Console.WriteLine("Kieu du lieu cua y la {0}", y.GetType().ToString());
            //y = 12.5; //sẽ báo lỗi, do khác kiểu với biến y khai báo ban đầu
            var z = "abc";
            Console.WriteLine("Kieu du lieu cua z la {0}", z.GetType().ToString());
            Console.ReadLine();
            //chỉ nên dùng nội suy khi thực sự ko biết kiểu của biến là gì
            //hạn chế dùng nội suy vì có thể gây nhiều bộ nhớ
        }
}
}
*/