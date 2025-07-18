using System;

class CHocSinh
{
    private string HoTen;
    private int Toan;
    private int Van;
    private float DiemTrungBinh;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap diem toan: ");
        Toan = int.Parse(Console.ReadLine());
        Console.Write("Nhap diem van: ");
        Van = int.Parse(Console.ReadLine());
    }

    public void XuLy()
    {
        DiemTrungBinh = (float)(Toan + Van) / 2;
    }

    public void Xuat()
    {
        Console.Write("\n Ho ten: " + HoTen);
        Console.Write("\n Toan: " + Toan);
        Console.Write("\n Van: " + Van);
        Console.Write("\n Diem trung binh: " + DiemTrungBinh);
    }
}

class Program
{
    static void Main()
    {
        CHocSinh hs = new CHocSinh();

        hs.Nhap();
        hs.XuLy();
        hs.Xuat();
    }
}
