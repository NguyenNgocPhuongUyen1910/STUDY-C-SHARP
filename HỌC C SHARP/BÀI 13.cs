using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_13
    {
        public static void Main()
        {
            bai13_2();
        }
        // SỐ RANDOM
        public static void bai13_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random(); // cú pháp để tạo ra 1 đối tượng có thể sinh ra số ngẫu nhiên
            // random số ngẫu nhiên (số begin, sát end) begin ko nhập thì mặc định begin=0
            int soNgauNhien = rd.Next(1,10);
            Console.WriteLine("Số ngẫu nhiên máy sinh ra là: "+soNgauNhien);

            //muốn lấy số ngẫu nhiên trong đoạn [0;1) 0 đến sát 1
            double k2 = rd.NextDouble();
            Console.WriteLine("Số ngẫu nhiên 2 là " + k2);

            //muốn cho ra số 1.25334445
            double k3 = k2 + soNgauNhien;
            Console.WriteLine("Giá trị ngẫu nhiên mong muốn là " + k3);
            //cách 2
            double k4 = k2 * 10;
            Console.WriteLine("Giá trị ngẫu nhiên 2 mong muốn là " + k4);

            Console.ReadLine();
        }

        // DATE TIME
        public static void bai13_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime birthday = new DateTime(2005, 10, 19);
            Console.WriteLine("Ngày tháng năm sinh của Neyu là "+birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngày sinh của Neyu là " + birthday.ToString("dd"));
            Console.WriteLine("Tháng năm sinh của Neyu là " + birthday.ToString("MM"));
            Console.WriteLine("Năm sinh của Neyu là " + birthday.ToString("yyyy"));

            // Viết chương trình cho người dùng nhập vào ngày tháng năm sinh
            Console.WriteLine("Nhập ngày tháng năm sinh của bạn (ngày/tháng/năm): ");
            string s= Console.ReadLine();
            DateTime birthday2 = DateTime.Parse(s);
            Console.WriteLine("Ngày sinh của bạn vừa nhập là " + birthday2.ToString("dd"));
            Console.WriteLine("Tháng sinh của bạn vừa nhập là " + birthday2.ToString("MM"));
            Console.WriteLine("Năm sinh của bạn vừa nhập là " + birthday2.ToString("yyyy"));

            Console.ReadLine();
        }
    }
}
