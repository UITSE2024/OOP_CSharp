using System;
public class Program
{
    public static void MinhHoaCHonSo()
    {
        // === NHOM KHOI TAO ===
        CHonSo A = new CHonSo();
        Console.WriteLine("\nNhap doi tuong A:");
        A.Nhap();
        Console.Write("Thong tin doi tuong A: "); A.Xuat();

        CHonSo B = new CHonSo();
        Console.WriteLine("\nNhap doi tuong B: ");
        B.Nhap();
        Console.Write("Thong tin B: " + B);

        CHonSo C = new CHonSo();
        Console.Write("\nDoi tuong C (mac dinh): "); C.Xuat();

        CHonSo D = new CHonSo(B);
        Console.Write("\nDoi tuong D (sao chep tu B): "); D.Xuat();

        CHonSo E = new CHonSo(1, 2, 3);
        Console.Write("\nDoi tuong E (day du): "); E.Xuat();

        CHonSo F = new CHonSo(5, 6);
        Console.Write("\nDoi tuong F (biet phan nguyen va tu so): "); F.Xuat();

        CHonSo G = new CHonSo(7);
        Console.Write("\nDoi tuong G (biet phan nguyen): "); G.Xuat();

        CHonSo H = new CHonSo();
        H.KhoiTao();
        Console.Write("\nDoi tuong H (KhoiTao khong doi so): "); H.Xuat();

        CHonSo I = new CHonSo();
        I.KhoiTao(E);
        Console.Write("\nDoi tuong I (KhoiTao tu E): "); I.Xuat();

        CHonSo J = new CHonSo();
        J.KhoiTao(4, 5, 6);
        Console.Write("\nDoi tuong J (KhoiTao 3 tham so): "); J.Xuat();

        // === NHOM CUNG CAP THONG TIN ===
        Console.WriteLine("\nPhan nguyen J: " + J.getNguyen());
        Console.WriteLine("Tu so J: " + J.getTu());
        Console.WriteLine("Mau so J: " + J.getMau());
        Console.WriteLine("Gia tri thuc J: " + J.getGiaTri());

        // === NHOM CAP NHAT THONG TIN ===
        CHonSo K = new CHonSo();
        K.Gan(J);
        Console.Write("\nDoi tuong K (gan tu J): "); K.Xuat();

        CHonSo L = new CHonSo();
        L.setNguyen(8);
        L.setTu(9);
        L.setMau(10);
        Console.Write("Doi tuong L (set thu cong): "); L.Xuat();

        // === NHOM KIEM TRA ===
        CHonSo M = new CHonSo(1, 1, 2);
        CHonSo N = new CHonSo(0, 3, 6);

        Console.WriteLine("\nM == N? " + (M == N));
        Console.WriteLine("M != N? " + (M != N));
        Console.WriteLine("M > N? " + (M > N));
        Console.WriteLine("M < N? " + (M < N));
        Console.WriteLine("M >= N? " + (M >= N));
        Console.WriteLine("M <= N? " + (M <= N));

        Console.WriteLine("M co nghia? " + M.isCoNghia());
        Console.WriteLine("M toi gian? " + M.isToiGian());
        Console.WriteLine("M bang 0? " + M.isKhong());
        Console.WriteLine("M duong? " + M.isDuong());
        Console.WriteLine("M am? " + M.isAm());

        // === NHOM XU LY ===
        CHonSo O = new CHonSo(1, 2, 3);
        CHonSo P = new CHonSo(2, 1, 3);

        CHonSo Q = O + P;
        Console.Write("\nO + P = "); Q.Xuat();

        CHonSo R = O - P;
        Console.Write("\nO - P = "); R.Xuat();

        CHonSo S = O * P;
        Console.Write("\nO * P = "); S.Xuat();

        CHonSo T = O / P;
        Console.Write("\nO / P = "); T.Xuat();

        ++O;
        Console.Write("\n++O = "); O.Xuat();

        --O;
        Console.Write("\n--O = "); O.Xuat();

        O++;
        Console.Write("\nO++ = "); O.Xuat();

        O--;
        Console.Write("\nO-- = "); O.Xuat();

        Console.WriteLine("\nUCLN cua O: " + O.UCLN());

        O.RutGonPhanSo();
        Console.Write("\nO sau RutGonPhanSo: "); O.Xuat();

        O.RutGon();
        Console.Write("\nO sau RutGon hon so: "); O.Xuat();

        Console.WriteLine("\nDau cua O: " + O.XetDau());
    }

    public static void Main()
    {
        MinhHoaCHonSo();
    }
}
