using System;

public class Program
{
    public static int MinhHoaCThoiGian()
    {
        // === NHÓM KHỞI TẠO ===
        CThoiGian A = new CThoiGian();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        CThoiGian B = new CThoiGian();
        Console.Write("\nNhap doi tuong B: ");
        B.Nhap();
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        CThoiGian C = new CThoiGian();
        Console.Write("\nThong tin doi tuong C (mac dinh): "); C.Xuat();

        CThoiGian D = new CThoiGian(B);
        Console.Write("\nThong tin doi tuong D (sao chep tu B): "); D.Xuat();

        CThoiGian E = new CThoiGian(1, 2, 3);
        Console.Write("\nThong tin doi tuong E (day du): "); E.Xuat();

        CThoiGian F = new CThoiGian(1, 2);
        Console.Write("\nThong tin doi tuong F (2 tham so): "); F.Xuat();

        CThoiGian G = new CThoiGian(1);
        Console.Write("\nThong tin doi tuong G (1 tham so): "); G.Xuat();

        CThoiGian H = new CThoiGian(1000L);
        Console.Write("\nThong tin doi tuong H (giay): "); H.Xuat();

        CThoiGian I = new CThoiGian();
        I.KhoiTao();
        Console.Write("\nThong tin doi tuong I (Khoi tao khong doi so): "); I.Xuat();

        CThoiGian J = new CThoiGian();
        J.KhoiTao(E);
        Console.Write("\nThong tin doi tuong J (Khoi tao tu E): "); J.Xuat();

        CThoiGian K = new CThoiGian();
        K.KhoiTao(1, 2, 3);
        Console.Write("\nThong tin doi tuong K (Khoi tao 3 tham so): "); K.Xuat();

        CThoiGian L = new CThoiGian();
        L.KhoiTao(1, 2);
        Console.Write("\nThong tin doi tuong L (Khoi tao 2 tham so): "); L.Xuat();

        CThoiGian M = new CThoiGian();
        M.KhoiTao(1);
        Console.Write("\nThong tin doi tuong M (Khoi tao 1 tham so): "); M.Xuat();

        CThoiGian N = new CThoiGian();
        N.KhoiTao(1000L);
        Console.Write("\nThong tin doi tuong N (Khoi tao bang giay): "); N.Xuat();

        // === NHÓM CUNG CẤP THÔNG TIN ===
        Console.Write("\nXuat J: "); J.Xuat();

        Console.Write("\nGio cua J: " + J.getGio());
        Console.Write("\nPhut cua J: " + J.getPhut());
        Console.Write("\nGiay cua J: " + J.getGiay());

        // === NHÓM CẬP NHẬT THÔNG TIN ===
        CThoiGian O = new CThoiGian();
        O = J.Gan(J);
        Console.Write("\nThong tin doi tuong O (gan tu J): "); O.Xuat();

        CThoiGian P = new CThoiGian();
        P.setGio(1);
        P.setPhut(2);
        P.setGiay(3);
        Console.Write("\nThong tin doi tuong P (setGio, setPhut, setGiay): "); P.Xuat();

        // === NHÓM KIỂM TRA ===
        CThoiGian Q = new CThoiGian(13, 4, 5);
        CThoiGian R = new CThoiGian(21, 2, 1);
        Console.WriteLine("\nQ == R? " + (Q == R));
        Console.WriteLine("Q != R? " + (Q != R));
        Console.WriteLine("Q > R?  " + (Q > R));
        Console.WriteLine("Q < R?  " + (Q < R));
        Console.WriteLine("Q >= R? " + (Q >= R));
        Console.WriteLine("Q <= R? " + (Q <= R));

        Console.WriteLine("Q hop le? " + Q.ktHopLe());

        Console.WriteLine("Q thuoc gio Ti? " + Q.ktGioTi());
        Console.WriteLine("Q thuoc gio Suu? " + Q.ktGioSuu());
        Console.WriteLine("Q thuoc gio Dan? " + Q.ktGioDan());
        Console.WriteLine("Q thuoc gio Mao? " + Q.ktGioMao());
        Console.WriteLine("Q thuoc gio Thin? " + Q.ktGioThin());
        Console.WriteLine("Q thuoc gio Ty? " + Q.ktGioTy());
        Console.WriteLine("Q thuoc gio Ngo? " + Q.ktGioNgo());
        Console.WriteLine("Q thuoc gio Mui? " + Q.ktGioMui());
        Console.WriteLine("Q thuoc gio Than? " + Q.ktGioThan());
        Console.WriteLine("Q thuoc gio Dau? " + Q.ktGioDau());
        Console.WriteLine("Q thuoc gio Tuat? " + Q.ktGioTuat());
        Console.WriteLine("Q thuoc gio Hoi? " + Q.ktGioHoi());

        Console.WriteLine("Q thuoc buoi Sang? " + Q.ktSang());
        Console.WriteLine("Q thuoc buoi Trua? " + Q.ktTrua());
        Console.WriteLine("Q thuoc buoi Chieu? " + Q.ktChieu());
        Console.WriteLine("Q thuoc buoi Toi? " + Q.ktToi());
        Console.WriteLine("Q thuoc buoi Dem? " + Q.ktDem());

        Console.WriteLine("Q trung voi R? " + Q.ktTrung(R));
        Console.WriteLine("Q khong trung voi R? " + Q.ktKhongTrung(R));

        // === NHÓM XỬ LÝ ===
        CThoiGian S = new CThoiGian(10, 30, 15);
        CThoiGian T = new CThoiGian(8, 45, 50);

        Console.Write("Nhap so giay k: ");
        long k = long.Parse(Console.ReadLine());

        long tong = S + T;
        Console.Write("\nS + T = ");
        CThoiGian Q1 = new CThoiGian();
        Q1.KhoiTao(tong);

        long hieu = S - T;
        Console.Write("\nS - T = ");
        CThoiGian Q2 = new CThoiGian();
        Q2.KhoiTao(hieu);

        CThoiGian Q3 = S + k;
        Console.Write("\nS + k = ");
        Q3.Xuat();

        CThoiGian Q4 = T - k;
        Console.Write("\nT - k = ");
        Q4.Xuat();

        S++;
        Console.Write("\nS++ = ");
        S.Xuat();

        T--;
        Console.Write("\nT-- = ");
        T.Xuat();

        long kc = S.KhoangCach(T);
        Console.WriteLine("\nKhoang cach giua S va T = " + kc + " giay");

        Console.WriteLine("\nSo thu tu giay cua S = " + S.SoThuTuGiay());
        Console.WriteLine("So thu tu giay cua T = " + T.SoThuTuGiay());
        return 0;
    }

    public static void Main()
    {
        MinhHoaCThoiGian();
    }
}