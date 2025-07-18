using System;

class CPhanSo
{
    private int Tu;
    private int Mau;

    public CPhanSo(int TuTu = 0, int MauMau = 1)
    {
        Tu = TuTu;
        Mau = MauMau != 0 ? MauMau : 1;
    }

    public static CPhanSo operator -(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        return temp;
    }

    public static bool operator >(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = a - b;
        return temp.Tu * temp.Mau > 0;
    }

    public static bool operator <(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = a - b;
        return temp.Tu * temp.Mau < 0;
    }

    public void Xuat()
    {
        Console.WriteLine($"{Tu}/{Mau}");
    }
}

class Program
{
    static void Main()
    {
        CPhanSo ps1 = new CPhanSo(3, 4);
        CPhanSo ps2 = new CPhanSo(2, 3);

        Console.Write("Phan so 1: ");
        ps1.Xuat();
        Console.Write("Phan so 2: ");
        ps2.Xuat();

        Console.WriteLine("ps1 > ps2: " + (ps1 > ps2));
        Console.WriteLine("ps1 < ps2: " + (ps1 < ps2));
    }
}
