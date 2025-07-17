using System;

public class CThoiGian
{
    private int gio;
    private int phut;
    private int giay;

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public void Nhap()
    {
        Console.Write("Nhap gio: ");
        gio = int.Parse(Console.ReadLine());
        Console.Write("Nhap phut: ");
        phut = int.Parse(Console.ReadLine());
        Console.Write("Nhap giay: ");
        giay = int.Parse(Console.ReadLine());
    }

    public CThoiGian()
    {
        gio = 0;
        phut = 0;
        giay = 0;
    }

    public CThoiGian(CThoiGian x)
    {
        gio = x.gio;
        phut = x.phut;
        giay = x.giay;
    }

    public CThoiGian(int giogio, int phutphut, int giaygiay)
    {
        gio = giogio;
        phut = phutphut;
        giay = giaygiay;
    }

    public CThoiGian(int giogio, int phutphut)
    {
        gio = giogio;
        phut = phutphut;
        giay = 0;
    }

    public CThoiGian(int giogio)
    {
        gio = giogio;
        phut = 0;
        giay = 0;
    }

    public CThoiGian(long sttgiay)
    {
        if (sttgiay < 0)
            sttgiay = 0;

        if (sttgiay >= 86400)
            sttgiay %= 86400;

        gio = (int)(sttgiay / 3600);
        phut = (int)((sttgiay % 3600) / 60);
        giay = (int)((sttgiay % 3600) % 60);
        // Trong C# phải ép kiểu long thành int mới gán được
    }

    public void KhoiTao()
    {
        gio = 0;
        phut = 0;
        giay = 0;
    }

    public void KhoiTao(CThoiGian x)
    {
        gio = x.gio;
        phut = x.phut;
        giay = x.giay;
    }

    public void KhoiTao(int giogio, int phutphut, int giaygiay)
    {
        gio = giogio;
        phut = phutphut;
        giay = giaygiay;
    }

    public void KhoiTao(int giogio, int phutphut)
    {
        gio = giogio;
        phut = phutphut;
        giay = 0;
    }

    public void KhoiTao(int giogio)
    {
        gio = giogio;
        phut = 0;
        giay = 0;
    }

    public void KhoiTao(long sttgiay)
    {
        if (sttgiay < 0)
            sttgiay = 0;

        if (sttgiay >= 86400)
            sttgiay %= 86400;

        gio = (int)(sttgiay / 3600);
        phut = (int)((sttgiay % 3600) / 60);
        giay = (int)((sttgiay % 3600) % 60);
        // Trong C# phải ép kiểu long thành int mới gán được
    }

    // === NHÓM PHƯƠNG THỨC CUNG CẤP THÔNG TIN ===
    public void Xuat()
    {
        Console.WriteLine($"\nGio: {gio}");
        Console.WriteLine($"\nPhut: {phut}");
        Console.WriteLine($"\nGiay: {giay}");
    }

    public int getGio()
    {
        return gio;
    }

    public int getPhut()
    {
        return phut;
    }

    public int getGiay()
    {
        return giay;
    }

    // === NHÓM PHƯƠNG THỨC CẬP NHẬT THÔNG TIN ===
    public CThoiGian Gan(CThoiGian x)
    {
        gio = x.gio;
        phut = x.phut;
        giay = x.giay;
        return this;
    }

    public void setGio(int giogio)
    {
        gio = giogio;
    }

    public void setPhut(int phutphut)
    {
        phut = phutphut;
    }

    public void setGiay(int giaygiay)
    {
        giay = giaygiay;
    }

    // === NHÓM PHƯƠNG THỨC KIỂM TRA ===
    public static bool operator ==(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() == x2.SoThuTuGiay())
            return true;
        return false;
    }

    public static bool operator !=(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() != x2.SoThuTuGiay())
            return true;
        return false;
    }

    public static bool operator <(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() < x2.SoThuTuGiay())
            return true;
        return false;
    }

    public static bool operator >(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() > x2.SoThuTuGiay())
            return true;
        return false;
    }

    public static bool operator <=(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() <= x2.SoThuTuGiay())
            return true;
        return false;
    }

    public static bool operator >=(CThoiGian x1, CThoiGian x2)
    {
        if (x1.SoThuTuGiay() >= x2.SoThuTuGiay())
            return true;
        return false;
    }

    public bool ktGio()
    {
        if (gio > 23 || gio < 0)
            return false;
        return true;
    }

    public bool ktPhut()
    {
        if (phut > 59 || phut < 0)
            return false;
        return true;
    }

    public bool ktGiay()
    {
        if (giay > 59 || giay < 0)
            return false;
        return true;
    }

    public bool ktHopLe()
    {
        if (!ktGio())
            return false;
        if (!ktPhut())
            return false;
        if (!ktGiay())
            return false;
        return true;
    }

    public bool ktGioTi()
    {
        if (gio >= 23 || gio < 1)
            return true;
        return false;
    }

    public bool ktGioSuu()
    {
        if (gio >= 1 && gio < 3)
            return true;
        return false;
    }

    public bool ktGioDan()
    {
        if (gio >= 3 && gio < 5)
            return true;
        return false;
    }

    public bool ktGioMao()
    {
        if (gio >= 5 && gio < 7)
            return true;
        return false;
    }

    public bool ktGioThin()
    {
        if (gio >= 7 && gio < 9)
            return true;
        return false;
    }

    public bool ktGioTy()
    {
        if (gio >= 9 && gio < 11)
            return true;
        return false;
    }

    public bool ktGioNgo()
    {
        if (gio >= 11 && gio < 13)
            return true;
        return false;
    }

    public bool ktGioMui()
    {
        if (gio >= 13 && gio < 15)
            return true;
        return false;
    }

    public bool ktGioThan()
    {
        if (gio >= 15 && gio < 17)
            return true;
        return false;
    }

    public bool ktGioDau()
    {
        if (gio >= 17 && gio < 19)
            return true;
        return false;
    }

    public bool ktGioTuat()
    {
        if (gio >= 19 && gio < 21)
            return true;
        return false;
    }

    public bool ktGioHoi()
    {
        if (gio >= 21 && gio < 23)
            return true;
        return false;
    }

    public bool ktSang()
    {
        if (gio >= 1 && gio < 11)
            return true;
        return false;
    }

    public bool ktTrua()
    {
        if (gio >= 11 && gio < 13)
            return true;
        return false;
    }

    public bool ktChieu()
    {
        if (gio >= 13 && gio < 19)
            return true;
        return false;
    }

    public bool ktToi()
    {
        if (gio >= 19 && gio < 22)
            return true;
        return false;
    }

    public bool ktDem()
    {
        if (gio >= 22 || gio < 1)
            return true;
        return false;
    }

    public bool ktTrung(CThoiGian x)
    {
        if (gio != x.gio)
            return false;
        if (phut != x.phut)
            return false;
        if (giay != x.giay)
            return false;
        return true;
    }

    public bool ktKhongTrung(CThoiGian x)
    {
        if (gio != x.gio)
            return true;
        if (phut != x.phut)
            return true;
        if (giay != x.giay)
            return true;
        return false;
    }

    // === NHÓM PHƯƠNG THỨC XỬ LÝ ===
    public static long operator +(CThoiGian x1, CThoiGian x2)
    {
        CThoiGian temp = new CThoiGian(x2);
        return x1.SoThuTuGiay() + temp.SoThuTuGiay();
    }

    public static long operator -(CThoiGian x1, CThoiGian x2)
    {
        CThoiGian temp = new CThoiGian(x2);
        return x1.SoThuTuGiay() - temp.SoThuTuGiay();
    }

    public static CThoiGian operator +(CThoiGian x, long k)
    {
        int tongGiay = x.SoThuTuGiay() + (int)k;
        CThoiGian result = new CThoiGian();
        result.KhoiTao(tongGiay);
        return result;
    }

    public static CThoiGian operator -(CThoiGian x, long k)
    {
        int hieuGiay = x.SoThuTuGiay() - (int)k;
        CThoiGian result = new CThoiGian();
        result.KhoiTao(hieuGiay);
        return result;
    }

    public static CThoiGian operator ++(CThoiGian x)
    {
        int tongGiay = x.SoThuTuGiay() + 1;
        CThoiGian result = new CThoiGian();
        result.KhoiTao(tongGiay);
        return result;
    }

    public static CThoiGian operator --(CThoiGian x)
    {
        int hieuGiay = x.SoThuTuGiay() - 1;
        CThoiGian result = new CThoiGian();
        result.KhoiTao(hieuGiay);
        return result;
    }

    public long KhoangCach(CThoiGian x)
    {
        CThoiGian temp = new CThoiGian(x);
        return Math.Abs(SoThuTuGiay() - temp.SoThuTuGiay());
    }

    public int SoThuTuGiay()
    {
        return gio * 3600 + phut * 60 + giay;
    }

}