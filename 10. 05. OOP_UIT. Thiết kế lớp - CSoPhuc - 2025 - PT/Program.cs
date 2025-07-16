using System;

public class Program
{
    public static int MinhHoaCSoPhuc()
    {
        // === NHÓM KHỞI TẠO ===

        CSoPhuc A = new CSoPhuc();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        CSoPhuc B = new CSoPhuc();
        Console.Write("\nNhap doi tuong B: ");
        B.Nhap();
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        CSoPhuc C = new CSoPhuc();
        Console.Write("\nThong tin doi tuong C (mac dinh): "); C.Xuat();

        CSoPhuc D = new CSoPhuc(B);
        Console.Write("\nThong tin doi tuong D (sao chep tu B): "); D.Xuat();

        CSoPhuc E = new CSoPhuc(3.3f, 4.4f);
        Console.Write("\nThong tin doi tuong E (day du): "); E.Xuat();

        CSoPhuc F = new CSoPhuc(5.5f);
        Console.Write("\nThong tin doi tuong F (1 tham so): "); F.Xuat();

        CSoPhuc G = new CSoPhuc();
        G.KhoiTao();
        Console.Write("\nThong tin doi tuong G (KhoiTao khong doi so): "); G.Xuat();

        CSoPhuc H = new CSoPhuc();
        H.KhoiTao(E);
        Console.Write("\nThong tin doi tuong H (KhoiTao tu E): "); H.Xuat();

        CSoPhuc I = new CSoPhuc();
        I.KhoiTao(1.1f, 2.2f);
        Console.Write("\nThong tin doi tuong I (KhoiTao 2 tham so): "); I.Xuat();

        CSoPhuc J = new CSoPhuc();
        J.KhoiTao(6.6f);
        Console.Write("\nThong tin doi tuong J (KhoiTao 1 tham so): "); J.Xuat();

        // === NHÓM CUNG CẤP THÔNG TIN ===

        Console.WriteLine("\nPhan thuc cua J: " + J.GetThuc());
        Console.WriteLine("Phan ao cua J: " + J.GetAo());

        Console.Write("\nXuat J: "); J.Xuat();

        // === NHÓM CẬP NHẬT THÔNG TIN ===

        CSoPhuc K = new CSoPhuc();
        K = J.Gan(J);
        Console.Write("\nThong tin doi tuong K (gan tu J): "); K.Xuat();

        CSoPhuc L = new CSoPhuc();
        L.SetThuc(7.7f);
        L.SetAo(8.8f);
        Console.Write("\nThong tin doi tuong L (SetThuc, SetAo): "); L.Xuat();

        // === NHÓM KIỂM TRA ===

        CSoPhuc M = new CSoPhuc(3, 4);
        CSoPhuc N = new CSoPhuc(0, 5);
        Console.WriteLine("\nM == N? " + (M == N));
        Console.WriteLine("M != N? " + (M != N));
        Console.WriteLine("M > N?  " + (M > N));
        Console.WriteLine("M < N?  " + (M < N));
        Console.WriteLine("M >= N? " + (M >= N));
        Console.WriteLine("M <= N? " + (M <= N));

        Console.WriteLine("M thuần ảo? " + M.ktThuanAo());
        Console.WriteLine("M thuần thực? " + M.ktThuanThuc());

        // === NHÓM XỬ LÝ ===

        CSoPhuc O = new CSoPhuc(1, 2);
        CSoPhuc P = new CSoPhuc(3, 4);

        CSoPhuc Q = O + P;
        Console.Write("\nO + P = "); Q.Xuat();

        CSoPhuc R = O - P;
        Console.Write("\nO - P = "); R.Xuat();

        CSoPhuc S = O * P;
        Console.Write("\nO * P = "); S.Xuat();

        CSoPhuc T = O / P;
        Console.Write("\nO / P = "); T.Xuat();

        O += P;
        Console.Write("\nO += P => O = "); O.Xuat();

        O -= P;
        Console.Write("\nO -= P => O = "); O.Xuat();

        O *= P;
        Console.Write("\nO *= P => O = "); O.Xuat();

        O /= P;
        Console.Write("\nO /= P => O = "); O.Xuat();

        ++O;
        Console.Write("\n++O = "); O.Xuat();

        --O;
        Console.Write("\n--O = "); O.Xuat();

        O++;
        Console.Write("\nO++ = "); O.Xuat();

        O--;
        Console.Write("\nO-- = "); O.Xuat();

        CSoPhuc U = O.LuyThua(3);
        Console.Write("\nO^3 = "); U.Xuat();

        O.LuyThuaBang(2);
        Console.Write("\nO ^= 2 => O = "); O.Xuat();

        Console.WriteLine("\nModule cua O: " + O.Module());

        CSoPhuc V = O.LienHop();
        Console.Write("\nLien hop cua O: "); V.Xuat();

        CSoPhuc W = O.Tong(P);
        Console.Write("\nTong O + P (qua phuong thuc): "); W.Xuat();

        CSoPhuc X = O.Hieu(P);
        Console.Write("\nHieu O - P (qua phuong thuc): "); X.Xuat();

        CSoPhuc Y = O.Tich(P);
        Console.Write("\nTich O * P (qua phuong thuc): "); Y.Xuat();

        CSoPhuc Z = O.Thuong(P);
        Console.Write("\nThuong O / P (qua phuong thuc): "); Z.Xuat();

        return 0;
    }

    public static void Main()
    {
        MinhHoaCSoPhuc();
    }
}
