using System;

class Program
{
    static void Nhap(out string TenTen, out int ToanToan, out int VanVan)
    {
        Console.Write("Nhap ho ten: ");
        TenTen = Console.ReadLine();
        Console.Write("Nhap diem toan: ");
        ToanToan = int.Parse(Console.ReadLine());
        Console.Write("Nhap diem van: ");
        VanVan = int.Parse(Console.ReadLine());
    }

    static void XuLy(int ToanToan, int VanVan, out float DiemTB)
    {
        DiemTB = (float)(ToanToan + VanVan) / 2;
    }

    static void Xuat(string TenTen, int ToanToan, int VanVan, float DiemTB)
    {
        Console.Write("\n Ho ten: " + TenTen);
        Console.Write("\n Diem toan: " + ToanToan);
        Console.Write("\n Diem van: " + VanVan);
        Console.Write("\n Diem trung binh: " + DiemTB);
    }

    static void Main()
    {
        string HoTen;
        int Toan;
        int Van;
        float DiemTrungBinh;

        Nhap(out HoTen, out Toan, out Van);
        XuLy(Toan, Van, out DiemTrungBinh);
        Xuat(HoTen, Toan, Van, DiemTrungBinh);
    }
}