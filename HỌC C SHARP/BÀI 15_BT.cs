using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_15_BT
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Csharp23();

        }

        /// <summary>
        /// Csharp 19: Cho  str1 = “English = 78 Science = 83 Math = 68 History = 65”
        /// 1. tính tổng các số trong chuỗi trên
        /// 2. tính trung bình cộng
        /// </summary>
        public static void Csharp19()
        {
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string strSo = "";
            string[] lst = str1.Split(' '); //tách theo space
            foreach (string s1 in lst)
            {
                //Console.WriteLine(s1);
                foreach (char s2 in s1) //tiếp tục tách để tìm số
                {
                    //Console.WriteLine(s2);
                    if (char.IsDigit(s2))
                        strSo += s1 + " ";
                        break;
                }    
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim(); //xóa space ở cuối trong mảng strSo
            string[] lst2 = strSo.Split(' '); //tách strSo theo space
            int tong = 0;
            foreach (string s3 in lst2)
            {
                Console.WriteLine(s3);
                tong += int.Parse(s3); //s3 đang là kiểu string, phải ép thành kiểu int mới tính toán được
            }
            Console.WriteLine("Tổng các số cần tìm là "+tong);

            float tbc = (float)tong / (lst2.Length);
            Console.WriteLine("Số các phần tử là "+ lst2.Length);
            Console.WriteLine("Trung bình cộng là "+tbc);



            /* Cách ngắn gọn hơn để tính tổng
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            int sum = 0;
            foreach (string s in lst)
            {
                if (int.TryParse(s, out int Number))
                sum += Number;
            }
            Console.WriteLine(sum); */
        }


        /// <summary>
        /// Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
        /// *  mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái(chữ cái thường hoặc hoa đều được)
        /// và chứa ít nhất 1 chữ số 
        /// 2. cho người dùng nhập vào mật khẩu để login / so sánh, nếu đúng mở cửa, nếu sai quá 5 lần khóa đăng nhập, thoát chương trình
        /// </summary>
        public static void Csharp20()
        {
            Console.WriteLine("Mời nhập vào mật khẩu (ít nhất 6 ký tự chứa ít nhất 1 chữ cái và ít nhất 1 chữ số): ");
            string mk=Console.ReadLine();
            int demSo = 0, demKyTu = 0;
            bool check = true;
            while(check) //while(check==true)
            {
                foreach (char c in mk)
                {
                    if (char.IsDigit(c))
                        demSo++;
                    else if(char.IsLetter(c))
                        demKyTu++;
                }
                //Console.WriteLine(demSo);
                //Console.WriteLine(demKyTu);

                if (demSo*demKyTu != 0  && mk.Length >= 6)
                    check = false; // nếu mk hợp lệ thì dừng lệch while lại
                else
                {
                    Console.WriteLine("Vui lòng nhập lại mật khẩu: ");
                    mk = Console.ReadLine();
                    check = true; //tiếp tục kiểm tra mk mới nhập lại
                }    
            }
            Console.WriteLine("Bạn đã thiết lập mật khẩu thành công\nMật khẩu của bạn là {0}",mk);

            //2.
            string login;
            Console.WriteLine("Mời nhập mật khẩu để đăng nhập: ");
            login= Console.ReadLine();
            int demlogin = 0;
            while(true)
            {
                bool kq=mk.Equals(login);
                if(kq)
                {
                    Console.WriteLine("Đăng nhập thành công");
                    break;
                }
                else
                {
                    demlogin++;
                    if(demlogin < 5)
                    {
                        Console.WriteLine("Bạn đã  nhập sai mật khẩu {0}/5 lần , vui lòng nhập lại",demlogin);
                        login= Console.ReadLine();
                    }    
                    else
                    {
                        Console.WriteLine("Bạn đã nhập sai mật khẩu 5 lần, khóa đăng nhập");
                        break;
                    }    
                }
            }    
        }


        /// <summary>
        /// Csharp 2: Viết chương trình chuyển tin nhắn sang mật mã theo bảng	
        /// #a="abcdefghijklmnopqrstuvwxyz"   
        /// #b="zxcvbnmasdfghjklqwertyuiop“  
        /// </summary>
        public static void Csharp21()
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            Console.WriteLine("Nhập vào chuỗi cần mã hóa: ");
            string chuoiInput = Console.ReadLine();
            string chuoiOuput = "";
            foreach(char c in chuoiInput)
            {
                int indexKyTu = a.IndexOf(c); //tìm vị trí index của từng ký tự nhập vào so mới mảng a
                chuoiOuput += b[indexKyTu]; //gióng vị trí đó vào mảng b
            }
            Console.WriteLine("Chuỗi trước mã hóa là "+chuoiInput);
            Console.WriteLine("Chuỗi sau mã hóa là "+chuoiOuput);
        }


        /// <summary>
        /// Csharp 22: Cho chuỗi : a= “tôi chăm học  tôi chịu khó   tôi đẹp zai"
        /// đếm từ tôi trong string a trên
        /// </summary>
        public static void Csharp22()
        {
            string a = "tôi chăm học  tôi chịu khó   tôi đẹp zai";
            int dem = 0;
            string[] lst = a.Split(' ');
            foreach (string s in lst)
            {
                //Console.WriteLine(s);
                if ("tôi".Equals(s))
                    dem++;
            }
            Console.WriteLine("Số chữ tôi trong câu trên là " +dem );
        }


        /// <summary>
        /// Csharp 23: Viết chương trình tách số và chữ từ chuỗi nhập vào thành 2 chuỗi : 	
        /// * ví dụ nhập vào : abc123 sẽ tách và in ra thành 2 chuỗi abc và 123
        /// </summary>
        public static void Csharp23()
        {
            Console.WriteLine("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();
            string chu = "";
            string so = "";
            foreach(char c in chuoi)
            {
                if (char.IsDigit(c))
                    so += c;
                else if (char.IsLetter(c))
                    chu += c;
            }
            Console.WriteLine("Chuỗi chỉ gồm số là "+so);
            Console.WriteLine("Chuỗi chỉ gồm chữ là "+chu);
        }
    }
}
