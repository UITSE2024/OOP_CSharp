using System;

class Program
{
    static void Main()
    {
        string HoTen;
        int Toan;
        int Van;
        float DiemTrungBinh;

        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap diem toan: ");
        Toan = int.Parse(Console.ReadLine());

        Console.Write("Nhap diem van: ");
        Van = int.Parse(Console.ReadLine());

        DiemTrungBinh = (float)(Toan + Van) / 2;

        Console.Write("\n Ho ten: " + HoTen);
        Console.Write("\n Diem toan: " + Toan);
        Console.Write("\n Diem van: " + Van);
        Console.Write("\n Diem trung binh: " + DiemTrungBinh);
    }
}