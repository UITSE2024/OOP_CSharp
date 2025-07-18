using System;

class Program
{
    static string HoTen;
    static int Toan;
    static int Van;
    static float DiemTrungBinh;
    static void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap diem toan: ");
        Toan = int.Parse(Console.ReadLine());

        Console.Write("Nhap diem van: ");
        Van = int.Parse(Console.ReadLine());
    }
    static void XuLy()
    {
        DiemTrungBinh = (float)(Toan + Van) / 2;
    }
    static void Xuat()
    {
        Console.Write("\n Ho ten: " + HoTen);
        Console.Write("\n Diem toan: " + Toan);
        Console.Write("\n Diem van: " + Van);
        Console.Write("\n Diem trung binh: " + DiemTrungBinh);
    }
    static void Main()
    {
        Nhap();
        XuLy();
        Xuat();
    }
}