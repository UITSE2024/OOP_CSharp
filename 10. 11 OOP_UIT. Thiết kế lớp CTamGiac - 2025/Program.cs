using System;

public class Program
{
    public static int MinhHoaCTamGiac()
    {
        // === NHÓM KHỞI TẠO ===
        CTamGiac A = new CTamGiac();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        CDiem d1 = new CDiem(1, 1);
        CDiem d2 = new CDiem(4, 1);
        CDiem d3 = new CDiem(2.5f, 4);
        CTamGiac B = new CTamGiac(d1, d2, d3);
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        CTamGiac C = new CTamGiac(B);
        Console.Write("\nThong tin doi tuong C (sao chep B): "); C.Xuat();

        CTamGiac D = new CTamGiac(d1, d2);
        Console.Write("\nThong tin doi tuong D (2 diem): "); D.Xuat();

        CTamGiac E = new CTamGiac(d1);
        Console.Write("\nThong tin doi tuong E (1 diem): "); E.Xuat();

        CTamGiac F = new CTamGiac();
        F.KhoiTao(B);
        Console.Write("\nKhoiTao F tu B: "); F.Xuat();

        // === NHÓM TRUY CẬP ===
        CDiem A1 = F.getA();
        Console.Write("\nDiem A cua F: "); A1.Xuat();

        F.setB(new CDiem(6, 2));
        Console.Write("\nDoi B cua F thanh (6,2): "); F.Xuat();

        F.setC(7, 3);
        Console.Write("\nDoi C cua F thanh (7,3): "); F.Xuat();

        // === NHÓM KIỂM TRA ===
        Console.WriteLine("\nF hop le? " + F.ktHopLe());
        Console.WriteLine("F deu? " + F.ktDeu());
        Console.WriteLine("F can? " + F.ktCan());
        Console.WriteLine("F vuong? " + F.ktVuong());
        Console.WriteLine("F vuong can? " + F.ktVuongCan());
        Console.WriteLine("F trung voi B? " + F.ktTrung(B));
        Console.WriteLine("F khong trung voi B? " + F.ktKoTrung(B));

        // === NHÓM TÍNH TOÁN ===
        Console.WriteLine("Chu vi F = " + F.ChuVi());
        Console.WriteLine("Dien tich F = " + F.DienTich());

        Console.Write("\nTrong tam F: ");
        F.TrongTam().Xuat();

        Console.Write("\nTruc tam F: ");
        F.TrucTam().Xuat();

        // === TOÁN TỬ ===
        Console.WriteLine("\nF == B? " + (F == B));
        Console.WriteLine("F != B? " + (F != B));
        Console.WriteLine("F > B? " + (F > B));
        Console.WriteLine("F < B? " + (F < B));
        Console.WriteLine("F >= B? " + (F >= B));
        Console.WriteLine("F <= B? " + (F <= B));

        CTamGiac G = F + B;
        Console.Write("\nF + B = "); G.Xuat();

        CTamGiac H = F - B;
        Console.Write("\nF - B = "); H.Xuat();

        F += B;
        Console.Write("\nF += B: "); F.Xuat();

        F -= B;
        Console.Write("\nF -= B: "); F.Xuat();

        return 0;
    }

    public static void Main(string[] args)
    {
        MinhHoaCTamGiac();
    }
}
