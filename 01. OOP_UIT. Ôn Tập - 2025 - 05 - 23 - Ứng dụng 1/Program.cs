using System;

struct PhanSo
{
    public int Tu;
    public int Mau;
}

class Program
{
    static void Nhap(ref PhanSo x)
    {
        Console.Write("Nhap tu: ");
        x.Tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        x.Mau = int.Parse(Console.ReadLine());
    }

    static void Xuat(PhanSo x)
    {
        Console.Write("\n Tu: " + x.Tu);
        Console.Write("\n Mau: " + x.Mau);
    }

    static void RutGon(ref PhanSo x)
    {
        int a = Math.Abs(x.Tu);
        int b = Math.Abs(x.Mau);
        while (a * b != 0)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        x.Tu = x.Tu / (a + b);
        x.Mau = x.Mau / (a + b);
    }

    static void Main()
    {
        PhanSo ps = new PhanSo();
        Nhap(ref ps);
        RutGon(ref ps);
        Xuat(ps);
    }
}