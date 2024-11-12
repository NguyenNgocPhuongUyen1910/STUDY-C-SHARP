using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HỌC_C_SHARP
{
    internal class BÀI_15
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo chuỗi
            string chuoi1 = "Bình yên";
            Console.WriteLine(chuoi1);

            //2. Khai báo nguyên văn (thêm @)
            string chuoi2 = @"D:/Vũ.";
            string chuoi3="Ngày xưa có một \"chuyện tình\""; //để dấu " không bị lỗi
            string chuoi4 = "Mưa ướt đôi bờ vai em\nNhưng sẽ cuốn trôi ngày xưa ấy"; //xuống dòng
            string chuoi5 = "Không giống như là anh\t-Khi mưa chỉ khiến anh nghĩ về"; // dấu cách
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);
            Console.WriteLine(chuoi5);

            Console.WriteLine("        ");

            //3. Chuyển đổi sang chuỗi
            int i = 123;
            string chuoi6 = i.ToString(); //cách1
            string chuoi7 = i + ""; //cách 2
            string chuoi8 = Convert.ToString(i); //cách 3

            //4. Tách chuỗi ra thành các ký tử lẻ, cho vào 1 mảng
            string chuoi9 = "XinChao";
            char[] lst = chuoi8.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());

            //5. Trả về độ dài của chuỗi (số ký tự chuỗi, bao gồm space)
            string chuoi10 = "Phuong Uyen";
            int j = chuoi10.Length; //chú ý index text bắt đầu từ 0
            Console.WriteLine("Độ dài của chuỗi là "+j);
            Console.WriteLine("Ký tự đầu tiên của chuỗi là " + chuoi10[0]);
            Console.WriteLine("Ký tự cuối cùng của chuỗi là " + chuoi10[j-1]);

            Console.WriteLine("\nVÍ DỤ");

            //6. Ví dụ vận dung: Nhập vào 1 chuỗi, đếm có bao nhiêu ký tự...
            int demSo = 0, demChuThuong = 0, demInHoa = 0, demSpace = 0;
            string chuoi = "Phương Uyên sinh ngày 19";
            char[] lst1=chuoi.ToCharArray();
            foreach (char c in lst1)
            {
                //Console.WriteLine(c);
                if (char.IsDigit(c)) 
                    demSo++;
                else if (char.IsLower(c))
                    demChuThuong++;
                else if (char.IsUpper(c))
                    demInHoa++;
                else if (char.IsWhiteSpace(c))
                    demSpace++;
            }
            Console.WriteLine($"Chuỗi có {demSo} ký tự số");
            Console.WriteLine($"Chuỗi có {demChuThuong} ký tự viết thường");
            Console.WriteLine($"Chuỗi có {demInHoa} ký tự viết hoa");
            Console.WriteLine($"Chuỗi có {demSpace} ký tự là khoảng trắng");

            Console.WriteLine();

            //7. So  sánh chuỗi ( trả về kq bằng nhau là 0, lớn hơn là 1, nhỏ hơn là -1)
            string chuoi11="1234a";
            string chuoi12 = "1234";
            int sosanh = chuoi11.CompareTo(chuoi12);
            Console.WriteLine(sosanh);

            //8. Kiểm tra chuỗi con
            string chuoi13 = "abc";
            string chuoi14 = "dcasjsskaabcdicdjci";
            bool ktra=chuoi13.Contains(chuoi14);
            Console.WriteLine(ktra);

            Console.WriteLine();

            //9. Hàm Copyto
            string chuoi15 = "abcde";
            char[] lst2 = new char[6]; //tạo ra 1 mảng có độ dài bằng 6
            lst2[0] = '1';
            lst2[1] = '2';
            Console.WriteLine(lst2);
            chuoi15.CopyTo(1,lst2,2,4); //từ vị trí index1 của chuoi15 copy 4 kí tự, dán đè vào lst2
            Console.WriteLine(lst2); //cho kq 12bcde

            Console.WriteLine();

            //10. Hàm bool EndsWith(string value)
            string chuoi16 = "Bình Yên.mp3";
            bool kt = chuoi16.EndsWith("mp3"); //kiểm tra xem chuỗi có kết thúc bằng chuỗi con hay không? kq True or False
            Console.WriteLine(kt);

            //11. Gán chuỗi theo string.Format
            int n = 100;
            string chuoi17=string.Format($"n={n} và căn bậc hai của {n} là {Math.Sqrt(n)}");
            Console.WriteLine(chuoi17);

            //12. bool Equals (ktra xem 2 chuỗi có bằng nhau không? kq True or False
            string chuoi18 = "Hi Yu";
            string chuoi19 = "Ne";
            bool kt1=chuoi18.Equals(chuoi19);
            Console.WriteLine(kt1);

            //13. string.Insert (<vị trí start_index chuỗi ban đầu>,<chuỗi cần chèn>)
            chuoi18 = chuoi18.Insert(3,chuoi19);
            Console.WriteLine(chuoi18);

            Console.WriteLine();

            //14. IndexOf (tìm vị trí xuất hiện đầu tiên của ký tự)
            string chuoi20 = "turquoise.pu";
            int kq = chuoi20.IndexOf("u");
            Console.WriteLine("14: "+kq);

            //15. LastIndexOf (tìm vị trí xuất hiện cuối cùng của ký tự)
            int kq1=chuoi20.LastIndexOf("u");
            Console.WriteLine("15: "+kq1);

            //16. Remove (index,count)
            chuoi20 = chuoi20.Remove(2, 3); //xóa từ vị trí index 2, xóa 3 phần tử
            Console.WriteLine("16: "+chuoi20);

            //17. Replace
            string chuoi21 = "turquoise.neyu";
            chuoi21 = chuoi21.Replace(".", "nnp");
            Console.WriteLine("17: "+chuoi21);

            //18. StartsWith (ktra chuỗi có bắt đầu bằng chuỗi con hay không)
            bool kt2 = chuoi21.StartsWith("tur");
            Console.WriteLine("18: "+kt2);

            //19. Substring (trích lọc chuỗi con từ chuỗi ban đầu)
            string chuoi22 = "12345";
            string chuoi23 = chuoi22.Substring(2, 3);
            Console.WriteLine("19: " + chuoi23);

            //20. ToLower() trả về chữ thường, ToUpper() trả về chữ hoa

            //21. Trim() xóa toàn bộ khoảng trắng ở trước và sau (không xóa ở giữa)
            string chuoi24 = "      hehe     ";
            Console.WriteLine(chuoi24);
            chuoi24=chuoi24.Trim();
            Console.WriteLine(chuoi24);

            //22. TrimEnd() xóa space ở cuối
            //23. TrimStart() xóa space ở đầu
            Console.WriteLine();

            //24. Split('') tách chuỗi => trả về mảng
            string chuoi25 = @"D:\fanart\YeonJun\NEYU";
            string[] lst3 = chuoi25.Split('\\'); //tách từ dấu '\'
            Console.WriteLine(lst3[0]);
            Console.WriteLine(lst3[1]);
            Console.WriteLine(lst3[2]);
            Console.WriteLine(lst3[3]);

            //25. Join string nối các phần tử của 1 list thành 1 chuỗi
            string chuoi26 = string.Join('_', lst3);
            Console.WriteLine("Đã nối: "+chuoi26);
        }
    }
}