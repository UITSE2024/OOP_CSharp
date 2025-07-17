class CNgay
{
    private int Ngay;
    private int Thang;
    private int Nam;
    public void Nhap()
    {
        Console.Write("Nhap ngay: ");
        Ngay = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        Thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        Nam = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ngay: {0}", Ngay);
        Console.WriteLine("Thang: {0}", Thang);
        Console.WriteLine("Nam: {0}", Nam);
    }

    public int ktNhuan()
    {
        if (Nam % 4 == 0 && Nam % 100 != 0)
            return 1;
        if (Nam % 400 == 0)
            return 1;
        return 0;
    }
    //Cách 1 tìm ngày hôm qua
    public CNgay Homqua()
    {
        int[] NgayThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (this.ktNhuan() == 1)
            NgayThang[1] = 29;
        if (Ngay == 1 && Thang == 1 && Nam == 1)
            return this;
        CNgay kq = this;
        kq.Ngay--;
        if (kq.Ngay == 0)
        {
            kq.Thang--;
            if (kq.Thang == 0)
            {
                kq.Nam--;
                kq.Thang = 12;
            }
            kq.Ngay = NgayThang[kq.Thang - 1];
        }
        return kq;
    }
    //Cách 2 tìm ngày hôm qua
    public int sttTrongNam()
    {
        int[] NgayThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (this.ktNhuan() == 1)
            NgayThang[1] = 29;
        int stt = 0;
        for (int i = 1; i <= Thang - 1; i++)
            stt += NgayThang[i - 1];
        return stt + Ngay;
    }
    public long SoThuTu()
    {
        long stt = 0;
        for (int i = 1; i <= Nam - 1; i++)
        {
            stt += 365;
            CNgay temp = new CNgay();
            temp.Ngay = 1;
            temp.Thang = 1;
            temp.Nam = i;
            if (temp.ktNhuan() == 1)
                stt = stt + 1;
        }
        return stt + sttTrongNam();
    }
    public CNgay TimNgay(int nam, int stt)
    {
        int[] NgayThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        CNgay temp = new CNgay();
        temp.Ngay = 1;
        temp.Thang = 1;
        temp.Nam = nam;
        if (temp.ktNhuan() == 1)
            NgayThang[1] = 29;

        while (stt - NgayThang[temp.Thang - 1] > 0)
        {
            stt = stt - NgayThang[temp.Thang - 1];
            temp.Thang++;
        }
        temp.Ngay = stt;
        return temp;
    }
    public CNgay TimNgay(long stt)
    {
        int nam = 1;
        int sn = 365;
        while (stt - sn > 0)
        {
            stt = stt - sn;
            nam++;
            sn = 365;
            CNgay temp = new CNgay();
            temp.Ngay = 1;
            temp.Thang = 1;
            temp.Nam = nam;
            if (temp.ktNhuan() == 1)
                sn = 366;
        }
        return TimNgay(nam, (int)stt);
    }
    public CNgay Hom_Qua()
    {
        long stt = SoThuTu();
        stt = stt - 1;
        return TimNgay(stt);
    }
}

class ClassMain()
{
    static void Main()
    {
        CNgay a = new CNgay();
        a.Nhap();
        CNgay kq = a.Hom_Qua();
        Console.WriteLine("Ngay ban dau: ");
        a.Xuat();
        Console.WriteLine("Ngay hom qua: ");
        kq.Xuat();
    }
}

