using System;
using System.Collections.Generic;

abstract class CMachDien
{
    public virtual void Nhap()
    {
    }

    public virtual void Xuat()
    {
    }

    public virtual float TinhDienTro()
    {
        return 0;
    }
}

class CDienTro : CMachDien
{
    protected string MaSo;
    protected float R;

    public override void Nhap()
    {
        Console.Write("Nhap ma so: ");
        MaSo = Console.ReadLine();
        Console.Write("Nhap R: ");
        R = float.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.Write("Ma so: ");
        Console.WriteLine(MaSo);
        Console.Write("Dien tro R: ");
        Console.WriteLine(R);
    }

    public override float TinhDienTro()
    {
        return R;
    }
}

class CMachNoiTiep : CMachDien
{
    protected int n;
    protected CMachDien[] ds = new CMachDien[100];

    public override void Nhap()
    {
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap loai (0. Noi tiep, 1. Song song, 2. R): ");
            int loai = int.Parse(Console.ReadLine());
            switch (loai)
            {
                case 0: ds[i] = new CMachNoiTiep(); break;
                case 1: ds[i] = new CMachSongSong(); break;
                case 2: ds[i] = new CDienTro(); break;
            }
            ds[i].Nhap();
        }
    }

    public override void Xuat()
    {
        Console.Write("So luong mach dien thanh phan: ");
        Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            ds[i].Xuat();
        }
    }

    public override float TinhDienTro()
    {
        float s = 0;
        for (int i = 0; i < n; i++)
        {
            s += ds[i].TinhDienTro();
        }
        return s;
    }
}

class CMachSongSong : CMachDien
{
    protected int n;
    protected CMachDien[] ds = new CMachDien[100];

    public override void Nhap()
    {
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap loai (0. Noi tiep, 1. Song song, 2. R): ");
            int loai = int.Parse(Console.ReadLine());
            switch (loai)
            {
                case 0: ds[i] = new CMachNoiTiep(); break;
                case 1: ds[i] = new CMachSongSong(); break;
                case 2: ds[i] = new CDienTro(); break;
            }
            ds[i].Nhap();
        }
    }

    public override void Xuat()
    {
        Console.Write("So luong mach dien thanh phan: ");
        Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            ds[i].Xuat();
        }
    }

    public override float TinhDienTro()
    {
        float s = 0;
        for (int i = 0; i < n; i++)
        {
            s += 1 / ds[i].TinhDienTro();
        }
        return 1 / s;
    }
}

class Program
{
    static void Main()
    {
        CMachDien a;
        Console.Write("Nhap loai (0. NT, 1. SS, 2. R): ");
        int loai = int.Parse(Console.ReadLine());

        switch (loai)
        {
            case 0: a = new CMachNoiTiep(); break;
            case 1: a = new CMachSongSong(); break;
            case 2: a = new CDienTro(); break;
            default: return;
        }

        a.Nhap();

        Console.WriteLine("Mach dien ban dau: ");
        a.Xuat();

        float kq = a.TinhDienTro();
        Console.Write("Tong dien tro mach dien la: ");
        Console.WriteLine(kq);
    }
}
