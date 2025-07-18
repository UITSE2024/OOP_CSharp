using System;

struct Diem
{
    public float x;
    public float y;
}

class Program
{
    static void Nhap(ref Diem P)
    {
        Console.Write("Nhap x: ");
        P.x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        P.y = float.Parse(Console.ReadLine());
    }

    static void Xuat(Diem P)
    {
        Console.Write("\n x = : " + P.x);
        Console.Write("\n y = : " + P.y);
    }

    static float KhoangCach(Diem P, Diem Q)
    {
        return (float)Math.Sqrt((Q.x - P.x) * (Q.x - P.x) + (Q.y - P.y) * (Q.y - P.y));
    }

    static void Main()
    {
        Diem A = new Diem();
        Diem B = new Diem();
        Nhap(ref A);
        Nhap(ref B);

        float kq = KhoangCach(A, B);
        Xuat(A);
        Xuat(B);
        Console.Write("\n Ket qua = " + kq);
    }
}