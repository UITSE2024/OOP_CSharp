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
        Console.WriteLine("Tu: " + Tu);
        Console.WriteLine("Mau: " + Mau);
    }

    public CPhanSo Tong(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau + Mau * x.Tu;
        temp.Mau = Mau * x.Mau;
        return temp;
    }

    public static CPhanSo operator +(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau + a.Mau * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        return temp;
    }

    public static CPhanSo operator -(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        return temp;
    }

    public static CPhanSo operator *(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        return temp;
    }

    public static CPhanSo operator /(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau;
        temp.Mau = a.Mau * b.Tu;
        return temp;
    }
}

class Program
{
    static void Main()
    {
        CPhanSo a = new CPhanSo();
        CPhanSo b = new CPhanSo();
        CPhanSo kq;

        a.Nhap();
        b.Nhap();

        kq = a.Tong(b);
        Console.WriteLine("Tong la:");
        kq.Xuat();

        kq = a + b;
        Console.WriteLine("Tong:");
        kq.Xuat();

        kq = a - b;
        Console.WriteLine("Hieu:");
        kq.Xuat();

        kq = a * b;
        Console.WriteLine("Tich:");
        kq.Xuat();

        kq = a / b;
        Console.WriteLine("Thuong:");
        kq.Xuat();
    }
}
