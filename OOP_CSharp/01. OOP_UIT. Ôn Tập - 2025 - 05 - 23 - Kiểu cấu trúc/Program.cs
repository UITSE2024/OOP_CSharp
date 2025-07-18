using System;

struct HocSinh
{
    public string HoTen;
    public int Toan;
    public int Van;
    public float DiemTrungBinh;
}

class Program
{
    static void Nhap(ref HocSinh x)
    {
        Console.Write("Nhap ho ten: ");
        x.HoTen = Console.ReadLine();
        Console.Write("Nhap diem toan: ");
        x.Toan = int.Parse(Console.ReadLine());
        Console.Write("Nhap diem van: ");
        x.Van = int.Parse(Console.ReadLine());
    }

    static void XuLy(ref HocSinh x)
    {
        x.DiemTrungBinh = (float)(x.Toan + x.Van) / 2;
    }

    static void Xuat(HocSinh x)
    {
        Console.Write("\n Ho ten: " + x.HoTen);
        Console.Write("\n Diem toan: " + x.Toan);
        Console.Write("\n Diem van: " + x.Van);
        Console.Write("\n Diem trung binh: " + x.DiemTrungBinh);
    }

    static void Main()
    {
        HocSinh hs = new HocSinh();
        Nhap(ref hs);
        XuLy(ref hs);
        Xuat(hs);
    }
}