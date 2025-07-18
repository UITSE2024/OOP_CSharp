using System;

class CNgay
{
    private int Ngay;
    private int Thang;
    private int Nam;

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

    ~CNgay()
    {
        Console.WriteLine("Destructor (finalizer) duoc goi");
    }

    public void Xuat()
    {
        Console.WriteLine($"Ngay: {Ngay}/{Thang}/{Nam}");
    }
}

class Program
{
    static void Main()
    {
        CNgay a = new CNgay();
        CNgay b = new CNgay(16, 7, 2025);
        CNgay c = new CNgay(b);

        a.Xuat();
        b.Xuat();
        c.Xuat();
    }
}
