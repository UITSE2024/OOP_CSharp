using System;

public class Diem
{
    private float x;
    private float y;

    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.Write("\n x = " + x);
        Console.Write("\n y = " + y);
    }

    public float KhoangCach(Diem P)
    {
        return (float)Math.Sqrt((x - P.x) * (x - P.x) + (y - P.y) * (y - P.y));
    }
}

public class Program
{
    static void Main()
    {
        Diem A = new Diem();
        Diem B = new Diem();
        A.Nhap();
        B.Nhap();

        float kq = B.KhoangCach(A);
        A.Xuat();
        B.Xuat();
        Console.Write("\nKhoang cach la: " + kq);
    }
}