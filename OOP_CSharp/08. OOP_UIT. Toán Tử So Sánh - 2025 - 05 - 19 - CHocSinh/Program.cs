using System;

class CHocSinh
{
    private string HoTen;
    private int Toan;
    private int Van;
    private float DiemTrungBinh;

    public CHocSinh(string TenTen, int ToanToan, int VanVan)
    {
        HoTen = TenTen;
        Toan = ToanToan;
        Van = VanVan;
        DiemTrungBinh = (Toan + Van) / 2.0f;
    }

    //O day dinh nghia cac toan tu so sanh tra ve bool vi bat buoc phai tra ve bool

    public static bool operator >(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh > b.DiemTrungBinh;
    }

    public static bool operator <(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh < b.DiemTrungBinh;
    }

    public static bool operator >=(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh >= b.DiemTrungBinh;
    }

    public static bool operator <=(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh <= b.DiemTrungBinh;
    }

    public static bool operator ==(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh == b.DiemTrungBinh;
    }

    public static bool operator !=(CHocSinh a, CHocSinh b)
    {
        return a.DiemTrungBinh != b.DiemTrungBinh;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Toan: {Toan}, Van: {Van}, Điem TB: {DiemTrungBinh}");
    }
}

class Program
{
    static void Main()
    {
        CHocSinh hs1 = new CHocSinh("Nguyen Van A", 8, 9);
        CHocSinh hs2 = new CHocSinh("Tran Thi B", 7, 10);

        hs1.Xuat();
        hs2.Xuat();

        Console.WriteLine("hs1 > hs2: " + (hs1 > hs2));
        Console.WriteLine("hs1 < hs2: " + (hs1 < hs2));
        Console.WriteLine("hs1 >= hs2: " + (hs1 >= hs2));
        Console.WriteLine("hs1 <= hs2: " + (hs1 <= hs2));
        Console.WriteLine("hs1 == hs2: " + (hs1 == hs2));
        Console.WriteLine("hs1 != hs2: " + (hs1 != hs2));
    }
}
