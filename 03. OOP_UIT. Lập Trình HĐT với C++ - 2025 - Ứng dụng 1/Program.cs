using System;

class CPhanSo
{
    private int Tu;
    private int Mau;

    public void Nhap()
    {
        Console.Write("Nhap tu: ");
        Tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        Mau = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.Write("\n Tu: " + Tu);
        Console.Write("\n Mau: " + Mau);
    }

    public void RutGon()
    {
        int a = Math.Abs(Tu);
        int b = Math.Abs(Mau);

        while (a * b != 0)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }

        Tu = Tu / (a + b);
        Mau = Mau / (a + b);
    }
}

class Program
{
    static void Main()
    {
        CPhanSo ps = new CPhanSo();

        ps.Nhap();
        Console.Write("\n Phan so ban dau:");
        ps.Xuat();

        ps.RutGon();
        Console.Write("\n Phan so sau khi rut gon:");
        ps.Xuat();
    }
}
