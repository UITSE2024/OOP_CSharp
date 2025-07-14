using System;

public class Program
{
    public static int MinhHoaCDiemKhongGian()
    {
        // === NHÓM KHỞI TẠO ===

        // Nhập
        CDiemKhongGian A = new CDiemKhongGian();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.WriteLine("\nDia chi cua A: " + A.GetHashCode());
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        // Constructor kiểu nhập
        CDiemKhongGian B = new CDiemKhongGian();
        Console.Write("\nNhap doi tuong B: ");
        B.Nhap();
        Console.WriteLine("\nDia chi cua B: " + B.GetHashCode());
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        // Constructor mặc định
        CDiemKhongGian C = new CDiemKhongGian();
        Console.WriteLine("\nDia chi cua C: " + C.GetHashCode());
        Console.Write("\nThong tin doi tuong C: "); C.Xuat();

        // Constructor sao chép
        CDiemKhongGian D = new CDiemKhongGian(C);
        Console.WriteLine("\nDia chi cua D: " + D.GetHashCode());
        Console.Write("\nThong tin doi tuong D: "); D.Xuat();

        // Constructor đầy đủ
        CDiemKhongGian E = new CDiemKhongGian(1.1f, 2.2f, 3.3f);
        Console.WriteLine("\nDia chi cua E: " + E.GetHashCode());
        Console.Write("\nThong tin doi tuong E: "); E.Xuat();

        // Constructor 2 tham số
        CDiemKhongGian F = new CDiemKhongGian(4.4f, 5.5f);
        Console.WriteLine("\nDia chi cua F: " + F.GetHashCode());
        Console.Write("\nThong tin doi tuong F: "); F.Xuat();

        // Constructor 1 tham số
        CDiemKhongGian G = new CDiemKhongGian(6.6f);
        Console.WriteLine("\nDia chi cua G: " + G.GetHashCode());
        Console.Write("\nThong tin doi tuong G: "); G.Xuat();

        // KhoiTao mặc định
        CDiemKhongGian H = new CDiemKhongGian();
        H.KhoiTao();
        Console.WriteLine("\nDia chi cua H: " + H.GetHashCode());
        Console.Write("\nThong tin doi tuong H: "); H.Xuat();

        // KhoiTao sao chép
        CDiemKhongGian I = new CDiemKhongGian();
        I.KhoiTao(E);
        Console.WriteLine("\nDia chi cua I: " + I.GetHashCode());
        Console.Write("\nThong tin doi tuong I: "); I.Xuat();

        // KhoiTao 3 tham số
        CDiemKhongGian J = new CDiemKhongGian();
        J.KhoiTao(7.7f, 8.8f, 9.9f);
        Console.WriteLine("\nDia chi cua J: " + J.GetHashCode());
        Console.Write("\nThong tin doi tuong J: "); J.Xuat();

        // KhoiTao 2 tham số
        CDiemKhongGian K = new CDiemKhongGian();
        K.KhoiTao(10.1f, 11.2f);
        Console.WriteLine("\nDia chi cua K: " + K.GetHashCode());
        Console.Write("\nThong tin doi tuong K: "); K.Xuat();

        // KhoiTao 1 tham số
        CDiemKhongGian L = new CDiemKhongGian();
        L.KhoiTao(12.3f);
        Console.WriteLine("\nDia chi cua L: " + L.GetHashCode());
        Console.Write("\nThong tin doi tuong L: "); L.Xuat();

        // === NHÓM CUNG CẤP THÔNG TIN ===

        Console.WriteLine("\nHoanh do cua L: " + L.getX());
        Console.WriteLine("\nTung do cua L: " + L.getY());
        Console.WriteLine("\nCao do cua L: " + L.getZ());

        CDiemKhongGian M = new CDiemKhongGian(1, 2, 3);
        Console.WriteLine("\nDia chi cua M: " + M.GetHashCode());
        Console.Write("\nThong tin doi tuong M: "); M.Xuat();

        // === NHÓM CẬP NHẬT THÔNG TIN ===

        CDiemKhongGian N = new CDiemKhongGian();
        N = M.Gan(M);
        Console.WriteLine("\nDia chi cua N: " + N.GetHashCode());
        Console.Write("\nThong tin doi tuong N: "); N.Xuat();

        CDiemKhongGian O = new CDiemKhongGian();
        O.setX(9.9f);
        O.setY(8.8f);
        O.setZ(7.7f);
        Console.WriteLine("\nDia chi cua O: " + O.GetHashCode());
        Console.Write("\nThong tin doi tuong O: "); O.Xuat();

        // === NHÓM KIỂM TRA ===

        CDiemKhongGian P = new CDiemKhongGian(1, 2, 3);
        CDiemKhongGian Q = new CDiemKhongGian(4, 5, 6);
        Console.WriteLine("\nP == Q? " + (P == Q));
        Console.WriteLine("\nP != Q? " + (P != Q));
        Console.WriteLine("\nP > Q?  " + (P > Q));
        Console.WriteLine("\nP < Q?  " + (P < Q));
        Console.WriteLine("\nP >= Q? " + (P >= Q));
        Console.WriteLine("\nP <= Q? " + (P <= Q));

        CDiemKhongGian R = new CDiemKhongGian(0, 0, 0);
        CDiemKhongGian S = new CDiemKhongGian(5, 0, 0);
        CDiemKhongGian T = new CDiemKhongGian(0, 6, 0);
        CDiemKhongGian U = new CDiemKhongGian(0, 0, 7);
        Console.WriteLine("\nR trung goc? " + R.ktTrungGoc());
        Console.WriteLine("\nS thuoc truc hoanh? " + S.ktThuocHoanh());
        Console.WriteLine("\nT thuoc truc tung? " + T.ktThuocTung());
        Console.WriteLine("\nU thuoc truc cao? " + U.ktThuocCao());

        CDiemKhongGian V = new CDiemKhongGian(1, 2, 0);
        CDiemKhongGian W = new CDiemKhongGian(1, 0, 3);
        CDiemKhongGian X = new CDiemKhongGian(0, 2, 3);
        Console.WriteLine("\nV thuoc mat phang Oxy? " + V.ktThuocOxy());
        Console.WriteLine("\nW thuoc mat phang Oxz? " + W.ktThuocOxz());
        Console.WriteLine("\nX thuoc mat phang Oyz? " + X.ktThuocOyz());

        CDiemKhongGian Y = new CDiemKhongGian(9, 8, 7);
        CDiemKhongGian Z = new CDiemKhongGian(9, 8, 7);
        Console.WriteLine("\nY trung Z? " + Y.ktTrung(Z));
        Console.WriteLine("\nY khong trung Z? " + Y.ktKoTrung(Z));

        // === NHÓM XỬ LÝ ===

        CDiemKhongGian AA = new CDiemKhongGian(1, 2, 3);
        CDiemKhongGian AB = new CDiemKhongGian(4, 5, 6);
        CDiemKhongGian AC = AA + AB;
        Console.Write("\nThong tin doi tuong AC (AA + AB): "); AC.Xuat();
        AA += AB;
        Console.Write("\nThong tin doi tuong AA sau += AB: "); AA.Xuat();

        CDiemKhongGian AD = AA - AB;
        Console.Write("\nThong tin doi tuong AD (AA - AB): "); AD.Xuat();
        AA -= AB;
        Console.Write("\nThong tin doi tuong AA sau -= AB: "); AA.Xuat();

        float dot = AB * AB;
        Console.WriteLine("\nTich vo huong AB * AB = " + dot);

        Console.WriteLine("\nKhoang cach AB den goc toa do: " + AB.KhoangCachGoc());
        Console.WriteLine("\nKhoang cach AB den mp Oxy: " + AB.KhoangCachOxy());
        Console.WriteLine("\nKhoang cach AB den mp Oxz: " + AB.KhoangCachOxz());
        Console.WriteLine("\nKhoang cach AB den mp Oyz: " + AB.KhoangCachOyz());

        Console.WriteLine("\nKhoang cach AB den AC: " + AB.KhoangCach(AC));
        Console.WriteLine("\nKhoang cach X theo Ox: " + AB.KhoangCachX(AC));
        Console.WriteLine("\nKhoang cach Y theo Oy: " + AB.KhoangCachY(AC));
        Console.WriteLine("\nKhoang cach Z theo Oz: " + AB.KhoangCachZ(AC));

        CDiemKhongGian AE = AB.DoiXungGoc();
        Console.Write("\nDoi xung AB qua goc: "); AE.Xuat();

        CDiemKhongGian AF = AB.DoiXungHoanh();
        Console.Write("\nDoi xung AB qua truc hoanh: "); AF.Xuat();

        CDiemKhongGian AG = AB.DoiXungTung();
        Console.Write("\nDoi xung AB qua truc tung: "); AG.Xuat();

        CDiemKhongGian AH = AB.DoiXungCao();
        Console.Write("\nDoi xung AB qua truc cao: "); AH.Xuat();

        CDiemKhongGian AI = AB.DoiXungOxy();
        Console.Write("\nDoi xung AB qua mat phang Oxy: "); AI.Xuat();

        CDiemKhongGian AJ = AB.DoiXungOxz();
        Console.Write("\nDoi xung AB qua mat phang Oxz: "); AJ.Xuat();

        CDiemKhongGian AK = AB.DoiXungOyz();
        Console.Write("\nDoi xung AB qua mat phang Oyz: "); AK.Xuat();

        return 0;
    }

    public static void Main()
    {
        MinhHoaCDiemKhongGian();
    }
}
