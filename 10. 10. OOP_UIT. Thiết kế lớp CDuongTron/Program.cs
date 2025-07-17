using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._10.OOP_UIT.Thiết_kế_lớp_CDuongTron
{
    internal class Program
    {
        static void MinhHoaCDuongTron()
        {
            CDiem point1 = new CDiem(3, 4);
            CDiem point2 = new CDiem(5, 6);
            CDuongTron circle1 = new CDuongTron(point1, 10);
            CDuongTron circle2 = new CDuongTron(point2, 5);

            // Minh họa các phương thức nhập và xuất
            Console.WriteLine("Nhập thông tin cho vòng tròn 1:");
            circle1.Nhap(); // Nhập thông tin cho vòng tròn
            Console.WriteLine("Thông tin vòng tròn 1:");
            circle1.Xuat(); // Xuất thông tin vòng tròn

            Console.WriteLine("\nNhập thông tin cho vòng tròn 2:");
            circle2.Nhap(); // Nhập thông tin cho vòng tròn
            Console.WriteLine("Thông tin vòng tròn 2:");
            circle2.Xuat(); // Xuất thông tin vòng tròn

            // Minh họa các phép toán so sánh
            Console.WriteLine("\nVòng tròn 1 == Vòng tròn 2: " + (circle1 == circle2));
            Console.WriteLine("Vòng tròn 1 != Vòng tròn 2: " + (circle1 != circle2));
            Console.WriteLine("Vòng tròn 1 > Vòng tròn 2: " + (circle1 > circle2));
            Console.WriteLine("Vòng tròn 1 < Vòng tròn 2: " + (circle1 < circle2));
            Console.WriteLine("Vòng tròn 1 >= Vòng tròn 2: " + (circle1 >= circle2));
            Console.WriteLine("Vòng tròn 1 <= Vòng tròn 2: " + (circle1 <= circle2));

            // Minh họa các phương thức kiểm tra với gốc
            Console.WriteLine("\nKiểm tra vòng tròn 1 qua gốc: " + circle1.ktQuaGoc());
            Console.WriteLine("Kiểm tra vòng tròn 1 chứa gốc: " + circle1.ktChuaGoc());

            // Minh họa các phương thức kiểm tra tiếp xúc
            Console.WriteLine("\nKiểm tra tiếp xúc hoành với vòng tròn 1: " + circle1.ktTiepXucHoanh());
            Console.WriteLine("Kiểm tra tiếp xúc tung với vòng tròn 1: " + circle1.ktTiepXucTung());

            // Minh họa kiểm tra thuộc các phần tử
            Console.WriteLine("\nKiểm tra phần tử 1 với vòng tròn 1: " + circle1.ktPhanTu1());
            Console.WriteLine("Kiểm tra phần tử 2 với vòng tròn 1: " + circle1.ktPhanTu2());

            // Minh họa kiểm tra trùng nhau
            Console.WriteLine("\nKiểm tra vòng tròn 1 và vòng tròn 2 có trùng nhau không: " + circle1.ktTrung(circle2));

            // Minh họa phương thức tính chu vi và diện tích
            Console.WriteLine("\nChu vi vòng tròn 1: " + circle1.ChuVi());
            Console.WriteLine("Diện tích vòng tròn 1: " + circle1.DienTich());

            // Minh họa phương thức tính diện tích phụ
            Console.WriteLine("\nDiện tích phụ giữa vòng tròn 1 và vòng tròn 2: " + circle1.DienTichPhu(circle2));

            // Minh họa phương thức tính diện tích giao
            Console.WriteLine("\nDiện tích giao giữa vòng tròn 1 và vòng tròn 2: " + circle1.DienTichGiao(circle2));

            // Minh họa các phương thức kiểm tra cắt nhau
            Console.WriteLine("\nKiểm tra cắt nhau giữa vòng tròn 1 và vòng tròn 2: " + circle1.ktCat(circle2));
            Console.WriteLine("Kiểm tra tiếp xúc trong giữa vòng tròn 1 và vòng tròn 2: " + circle1.ktTiepXucTrong(circle2));
            Console.WriteLine("Kiểm tra tiếp xúc ngoài giữa vòng tròn 1 và vòng tròn 2: " + circle1.ktTiepXucNgoai(circle2));
            Console.WriteLine("Kiểm tra vòng tròn 1 nằm trong vòng tròn 2: " + circle1.ktNamTrong(circle2));
            Console.WriteLine("Kiểm tra vòng tròn 1 nằm ngoài vòng tròn 2: " + circle1.ktNamNgoai(circle2));

            // Minh họa phương thức kiểm tra đồng tâm
            Console.WriteLine("\nKiểm tra đồng tâm giữa vòng tròn 1 và vòng tròn 2: " + circle1.ktDongTam(circle2));
        }

        static void Main(string[] args)
        {
            MinhHoaCDuongTron();
        }
    }
}
