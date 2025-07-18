using System;

public class CNgay
{
    private int Ngay;
    private int Thang;
    private int Nam;

    public void CopyFrom(CNgay other)
    {
        this.Ngay = other.Ngay;
        this.Thang = other.Thang;
        this.Nam = other.Nam;
    }

    public void Nhap()
    {
        Console.Write("\nNhap ngay: ");
        Ngay = int.Parse(Console.ReadLine());
        Console.Write("\nNhap thang: ");
        Thang = int.Parse(Console.ReadLine());
        Console.Write("\nNhap nam: ");
        Nam = int.Parse(Console.ReadLine());
    }

    public CNgay()
    {
        Ngay = 1;
        Thang = 1;
        Nam = 1;
    }

    public CNgay(CNgay x)
    {
        Ngay = x.Ngay;
        Thang = x.Thang;
        Nam = x.Nam;
    }

    public CNgay(int NgayNgay, int ThangThang, int NamNam)
    {
        Ngay = NgayNgay;
        Thang = ThangThang;
        Nam = NamNam;
    }

    public CNgay(int ThangThang, int NamNam)
    {
        Ngay = 1;
        Thang = ThangThang;
        Nam = NamNam;
    }

    public CNgay(int NamNam)
    {
        Ngay = 1;
        Thang = 1;
        Nam = NamNam;
    }

    /// /////////////////////////////////////////////////////////////

    public CNgay(long stt)
    {
        CNgay temp = new CNgay();
        int sn = 365;
        while (stt - sn > 0)
        {
            temp.Nam++;
            stt -= sn;
            sn = temp.SoNgayToiDaTrongNam();
        }
        while (stt - temp.SoNgayToiDaTrongThang() > 0)
        {
            stt -= temp.SoNgayToiDaTrongThang();
            temp.Thang++;
        }
        temp.Ngay = (int)stt;
        CopyFrom(temp);
    }

    public void KhoiTao()
    {
        Ngay = 1;
        Thang = 1;
        Nam = 1;
    }

    public void KhoiTao(CNgay x)
    {
        Ngay = x.Ngay;
        Thang = x.Thang;
        Nam = x.Nam;
    }

    public void KhoiTao(int NgayNgay, int ThangThang, int NamNam)
    {
        Ngay = NgayNgay;
        Thang = ThangThang;
        Nam = NamNam;
    }

    public void KhoiTao(int ThangThang, int NamNam)
    {
        Ngay = 1;
        Thang = ThangThang;
        Nam = NamNam;
    }

    public void KhoiTao(int NamNam)
    {
        Ngay = 1;
        Thang = 1;
        Nam = NamNam;
    }

    public void KhoiTao(long stt)
    {
        CNgay temp = new CNgay();
        int sn = 365;
        while (stt - sn > 0)
        {
            temp.Nam++;
            stt -= sn;
            sn = temp.SoNgayToiDaTrongNam();
        }
        while (stt - temp.SoNgayToiDaTrongThang() > 0)
        {
            stt -= temp.SoNgayToiDaTrongThang();
            temp.Thang++;
        }
        temp.Ngay = (int)stt;
        CopyFrom(temp);
    }

    public void Xuat()
    {
        Console.Write("\nNgay: " + Ngay);
        Console.Write("\nThang: " + Thang);
        Console.Write("\nNam: " + Nam);
    }

    public int getNgay()
    {
        return Ngay;
    }

    public int getThang()
    {
        return Thang;
    }

    public int getNam()
    {
        return Nam;
    }

    public void XuatThu()
    {
        int stt = (int)SoThuTu();
        string[] thu = { "Chu nhat", "Thu hai", "Thu ba", "Thu tu", "Thu nam", "Thu sau", "Thu bay" };
        Console.WriteLine(thu[stt % 7]);
    }

    public void setNgay(int NgayNgay)
    {
        Ngay = NgayNgay;
    }

    public void setThang(int ThangThang)
    {
        Thang = ThangThang;
    }

    public void setNam(int NamNam)
    {
        Nam = NamNam;
    }

    public static bool operator ==(CNgay a, CNgay b)
    {
        if (a.Ngay == b.Ngay && a.Thang == b.Thang && a.Nam == b.Nam)
            return true;
        return false;
    }

    public static bool operator !=(CNgay a, CNgay b)
    {
        if (a.Ngay == b.Ngay && a.Thang == b.Thang && a.Nam == b.Nam)
            return false;
        return true;
    }

    public static bool operator >(CNgay a, CNgay b)
    {
        if (a.Nam > b.Nam)
            return true;
        if (a.Nam < b.Nam)
            return false;
        if (a.Thang > b.Thang)
            return true;
        if (a.Thang < b.Thang)
            return false;
        if (a.Ngay > b.Ngay)
            return true;
        if (a.Ngay < b.Ngay)
            return false;
        return false;
    }

    public static bool operator <(CNgay a, CNgay b)
    {
        if (a.Nam > b.Nam)
            return false;
        if (a.Nam < b.Nam)
            return true;
        if (a.Thang > b.Thang)
            return false;
        if (a.Thang < b.Thang)
            return true;
        if (a.Ngay > b.Ngay)
            return false;
        if (a.Ngay < b.Ngay)
            return true;
        return false;
    }

    public static bool operator >=(CNgay a, CNgay b)
    {
        if (a.Nam > b.Nam)
            return true;
        if (a.Nam < b.Nam)
            return false;
        if (a.Thang > b.Thang)
            return true;
        if (a.Thang < b.Thang)
            return false;
        if (a.Ngay > b.Ngay)
            return true;
        if (a.Ngay < b.Ngay)
            return false;
        return true;
    }

    public static bool operator <=(CNgay a, CNgay b)
    {
        if (a.Nam > b.Nam)
            return false;
        if (a.Nam < b.Nam)
            return true;
        if (a.Thang > b.Thang)
            return false;
        if (a.Thang < b.Thang)
            return true;
        if (a.Ngay > b.Ngay)
            return false;
        if (a.Ngay < b.Ngay)
            return true;
        return true;
    }

    public bool ktNgay()
    {
        if (Ngay < 1)
            return false;
        if (Ngay > SoNgayToiDaTrongThang())
            return false;
        return true;
    }

    public bool ktThang()
    {
        if (Thang < 1)
            return false;
        if (Thang > 12)
            return false;
        return true;
    }

    public bool ktNam()
    {
        if (Nam < 1)
            return false;
        return true;
    }

    public bool ktNhuan()
    {
        if (Nam % 4 == 0 && Nam % 100 != 0)
            return true;
        if (Nam % 400 == 0)
            return true;
        return false;
    }

    public bool ktKhongNhuan()
    {
        if (Nam % 4 == 0 && Nam % 100 != 0)
            return false;
        if (Nam % 400 == 0)
            return false;
        return true;
    }

    public bool ktHopLe()
    {
        if (!ktNgay())
            return false;
        if (!ktThang())
            return false;
        if (!ktNam())
            return false;
        return true;
    }

    ~CNgay()
    {

    }

    public static long operator -(CNgay a, CNgay b)
    {
        return a.SoThuTu() - b.SoThuTu();
    }

    public static CNgay operator +(CNgay x, int k)
    {
        CNgay temp = new CNgay(x);
        while (k-- > 0)
        {
            temp++;
            k--;
        }
        return temp;
    }

    public static CNgay operator -(CNgay x, int k)
    {
        CNgay temp = new CNgay(x);
        while (k-- > 0)
        {
            temp--;
            k--;
        }
        return temp;
    }

    public static CNgay operator ++(CNgay x)
    {
        x.Ngay++;
        if (x.Ngay > x.SoNgayToiDaTrongThang())
        {
            x.Thang++;
            if (x.Thang > 12)
            {
                x.Nam++;
                x.Thang = 1;
            }
            x.Ngay = 1;
        }
        return x;
    }

    public static CNgay operator --(CNgay x)
    {
        if (x.Ngay == 1 && x.Thang == 1 && x.Nam == 1)
            return x;
        x.Ngay--;
        if (x.Ngay < 1)
        {
            x.Thang--;
            if (x.Thang < 1)
            {
                x.Nam--;
                x.Thang = 12;
            }
            x.Ngay = x.SoNgayToiDaTrongThang();
        }
        return x;
    }

    public int SoNgayToiDaTrongThang()
    {
        int[] NgayThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (ktNhuan() == true)
            NgayThang[1] = 29;
        return NgayThang[Thang - 1];
    }

    public int SoNgayToiDaTrongNam()
    {
        if (ktNhuan() == true)
            return 366;
        return 365;
    }

    public int SoThuTuTrongNam()
    {
        int stt = 0;
        for (int i = 1; i <= Thang - 1; i++)
        {
            CNgay temp = new CNgay(1, i, Nam);
            stt = stt + temp.SoNgayToiDaTrongThang();
        }
        return stt + Ngay;
    }

    public long SoThuTu()
    {
        long stt = 0;
        for (int i = 1; i <= Nam - 1; i++)
        {
            CNgay temp = new CNgay(1, 1, i);
            stt += temp.SoNgayToiDaTrongNam();
        }
        return stt + SoThuTuTrongNam();
    }

    public long KhoangCach(CNgay x)
    {
        return Math.Abs(SoThuTu() - x.SoThuTu());
    }

    public CNgay KeTiep()
    {
        Ngay++;
        if (Ngay > SoNgayToiDaTrongThang())
        {
            Thang++;
            if (Thang > 12)
            {
                Nam++;
                Thang = 1;
            }
            Ngay = 1;
        }
        return this;
    }

    public CNgay HomQua()
    {
        if (Ngay == 1 && Thang == 1 && Nam == 1)
            return this;

        Ngay--;
        if (Ngay < 1)
        {
            Thang--;
            if (Thang < 1)
            {
                Nam--;
                Thang = 12;
            }
            Ngay = SoNgayToiDaTrongThang();
        }
        return this;
    }

    public CNgay TruocDo(int k)
    {
        for (int i = 1; i <= k; i++)
            this.HomQua();
        return this;
    }

    public CNgay SauDo(int k)
    {
        for (int i = 1; i <= k; i++)
            this.KeTiep();
        return this;
    }

    public CNgay TimHomQua()
    {
        CNgay temp = new CNgay(this);
        if (Ngay == 1 && Thang == 1 && Nam == 1)
            return temp;
        temp.Ngay--;
        if (temp.Ngay < 1)
        {
            temp.Thang--;
            if (temp.Thang < 1)
            {
                temp.Nam--;
                temp.Thang = 12;
            }
            temp.Ngay = temp.SoNgayToiDaTrongThang();
        }
        return temp;
    }

    public CNgay TimKeTiep()
    {
        CNgay temp = new CNgay(this);
        temp.Ngay++;
        if (temp.Ngay > temp.SoNgayToiDaTrongThang())
        {
            temp.Thang++;
            if (temp.Thang > 12)
            {
                temp.Nam++;
                temp.Thang = 1;
            }
            temp.Ngay = 1;
        }
        return temp;
    }

    public CNgay TimTruocDo(int k)
    {
        CNgay temp = new CNgay(this);
        for (int i = 1; i <= k; i++)
            temp = temp.HomQua();
        return temp;
    }

    public CNgay TimSauDo(int k)
    {
        CNgay temp = new CNgay(this);
        for (int i = 1; i <= k; i++)
            temp = temp.TimKeTiep();
        return temp;
    }
}

class Program
{
    static void Main()
    {

    }
}