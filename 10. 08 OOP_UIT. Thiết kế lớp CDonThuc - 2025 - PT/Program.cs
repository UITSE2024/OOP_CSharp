using System;

public class Program
{
    public static int MinhHoaCDonThuc()
    {
        // === NHÓM KHỞI TẠO ===
        CDonThuc A = new CDonThuc();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        CDonThuc B = new CDonThuc();
        Console.Write("\nNhap doi tuong B: ");
        B.Nhap();
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        CDonThuc C = new CDonThuc();
        Console.Write("\nThong tin C (mac dinh): "); C.Xuat();

        CDonThuc D = new CDonThuc(B);
        Console.Write("\nThong tin D (sao chep tu B): "); D.Xuat();

        CDonThuc E = new CDonThuc(2.2f, 3);
        Console.Write("\nThong tin E (2 tham so): "); E.Xuat();

        CDonThuc F = new CDonThuc(5.5f);
        Console.Write("\nThong tin F (1 tham so thuc): "); F.Xuat();

        CDonThuc G = new CDonThuc(4);
        Console.Write("\nThong tin G (1 tham so mu): "); G.Xuat();

        CDonThuc H = new CDonThuc();
        H.KhoiTao();
        Console.Write("\nThong tin H (KhoiTao khong doi so): "); H.Xuat();

        CDonThuc I = new CDonThuc();
        I.KhoiTao(E);
        Console.Write("\nThong tin I (KhoiTao tu E): "); I.Xuat();

        CDonThuc J = new CDonThuc();
        J.KhoiTao(6.6f, 2);
        Console.Write("\nThong tin J (KhoiTao 2 tham so): "); J.Xuat();

        CDonThuc K = new CDonThuc();
        K.KhoiTao(7.7f);
        Console.Write("\nThong tin K (KhoiTao 1 tham so thuc): "); K.Xuat();

        CDonThuc L = new CDonThuc();
        L.KhoiTao(3);
        Console.Write("\nThong tin L (KhoiTao 1 tham so mu): "); L.Xuat();

        // === NHÓM CUNG CẤP ===
        Console.WriteLine("\nHe so cua L: " + L.getHeSo());
        Console.WriteLine("So mu cua L: " + L.getSoMu());

        // === NHÓM CẬP NHẬT ===
        CDonThuc M = new CDonThuc();
        M.setHeSo(8.8f);
        M.setSoMu(4);
        Console.Write("\nThong tin M (setHeSo, setSoMu): "); M.Xuat();

        // === NHÓM KIỂM TRA ===
        Console.WriteLine("\nDon thuc M co phai la 0? " + M.ktDonThucKhong());

        // === NHÓM TOÁN TỬ ===
        CDonThuc N = new CDonThuc(2, 3);
        CDonThuc O = new CDonThuc(3, 2);

        CDonThuc P = N * O;
        Console.Write("\nN * O = "); P.Xuat();

        CDonThuc Q = N / O;
        Console.Write("\nN / O = "); Q.Xuat();

        N *= O;
        Console.Write("\nN *= O => N = "); N.Xuat();

        N /= O;
        Console.Write("\nN /= O => N = "); N.Xuat();

        Console.WriteLine("\nN == O? " + (N == O));
        Console.WriteLine("N != O? " + (N != O));
        Console.WriteLine("N > O? " + (N > O));
        Console.WriteLine("N < O? " + (N < O));
        Console.WriteLine("N >= O? " + (N >= O));
        Console.WriteLine("N <= O? " + (N <= O));

        // === NHÓM XỬ LÝ ===
        CDonThuc R = N.Tich(O);
        Console.Write("\nTich N * O = "); R.Xuat();

        CDonThuc S = N.Thuong(O);
        Console.Write("\nThuong N / O = "); S.Xuat();

        CDonThuc T = N.DaoHam();
        Console.Write("\nDao ham cap 1 cua N: "); T.Xuat();

        CDonThuc U = N.DaoHam(2);
        Console.Write("\nDao ham cap 2 cua N: "); U.Xuat();

        CDonThuc V = N.NguyenHam();
        Console.Write("\nNguyen ham cap 1 cua N: "); V.Xuat();

        CDonThuc W = N.NguyenHam(2);
        Console.Write("\nNguyen ham cap 2 cua N: "); W.Xuat();

        return 0;
    }

    public static void Main(string[] args)
    {
        MinhHoaCDonThuc();
    }
}
