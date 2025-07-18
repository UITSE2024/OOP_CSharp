using System;
using System.Collections.Generic;

// Lớp cơ sở trừu tượng CChiTiet
public abstract class CChiTiet
{
    protected long MaSo { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhap ma so: ");
        MaSo = long.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.WriteLine($"Ma so: {MaSo}");
    }

    public virtual float TinhTien()
    {
        return 0;
    }

    public virtual CChiTiet TimKiem(long ms)
    {
        return MaSo == ms ? this : null;
    }

    public virtual int DemChiTietDon()
    {
        return 0;
    }
}

// Lớp CChiTietDon kế thừa từ CChiTiet
public class CChiTietDon : CChiTiet
{
    protected float GiaTien { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap gia tien: ");
        GiaTien = float.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Gia tien: {GiaTien}");
    }

    public override float TinhTien()
    {
        return GiaTien;
    }

    public override int DemChiTietDon()
    {
        return 1; // Chi tiết đơn đếm là 1
    }
}

// Lớp CChiTietPhuc kế thừa từ CChiTiet
public class CChiTietPhuc : CChiTiet
{
    protected int n; // Số lượng chi tiết thành phần
    protected List<CChiTiet> ds; // Danh sách chi tiết

    public CChiTietPhuc()
    {
        ds = new List<CChiTiet>();
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong chi tiet thanh phan: ");
        n = int.Parse(Console.ReadLine());
        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap chi tiet a[{i}] (0: Don, 1: Phuc): ");
            int type = int.Parse(Console.ReadLine());
            CChiTiet temp;
            if (type == 0)
                temp = new CChiTietDon();
            else
                temp = new CChiTietPhuc();
            temp.Nhap();
            ds.Add(temp);
        }
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"So luong chi tiet thanh phan: {n}");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Chi tiet a[{i}]:");
            ds[i].Xuat();
        }
    }

    public override float TinhTien()
    {
        float s = 0;
        foreach (var chiTiet in ds)
        {
            s += chiTiet.TinhTien();
        }
        return s;
    }

    public override CChiTiet TimKiem(long ms)
    {
        if (MaSo == ms)
            return this;
        foreach (var chiTiet in ds)
        {
            var kq = chiTiet.TimKiem(ms);
            if (kq != null)
                return kq;
        }
        return null;
    }

    public override int DemChiTietDon()
    {
        int count = 0;
        foreach (var chiTiet in ds)
        {
            count += chiTiet.DemChiTietDon();
        }
        return count;
    }
}

// Lớp CMay
public class CMay
{
    protected int n; // Số lượng chi tiết
    protected List<CChiTiet> ds; // Danh sách chi tiết

    public CMay()
    {
        ds = new List<CChiTiet>();
    }

    public void Nhap()
    {
        Console.Write("Nhap so luong chi tiet: ");
        n = int.Parse(Console.ReadLine());
        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap chi tiet a[{i}] (0: Don, 1: Phuc): ");
            int type = int.Parse(Console.ReadLine());
            CChiTiet temp;
            if (type == 0)
                temp = new CChiTietDon();
            else
                temp = new CChiTietPhuc();
            temp.Nhap();
            ds.Add(temp);
        }
    }

    public void Xuat()
    {
        Console.WriteLine($"So luong chi tiet: {n}");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Chi tiet a[{i}]:");
            ds[i].Xuat();
        }
    }

    public float TinhTien()
    {
        float s = 0;
        foreach (var chiTiet in ds)
        {
            s += chiTiet.TinhTien();
        }
        return s;
    }

    public CChiTiet TimKiem(long ms)
    {
        foreach (var chiTiet in ds)
        {
            var kq = chiTiet.TimKiem(ms);
            if (kq != null)
                return kq;
        }
        return null;
    }

    public int DemChiTietDon()
    {
        int count = 0;
        foreach (var chiTiet in ds)
        {
            count += chiTiet.DemChiTietDon();
        }
        return count;
    }
}

// Lớp chứa hàm Main
public class Program
{
    public static void Main(string[] args)
    {
        CMay may = new CMay();
        may.Nhap();
        Console.WriteLine("\nDanh sach chi tiet may:");
        may.Xuat();
        Console.WriteLine($"\nTong gia tri may: {may.TinhTien()}");
        Console.Write("Nhap ma so can tim: ");
        long ms = long.Parse(Console.ReadLine());
        var chiTiet = may.TimKiem(ms);
        if (chiTiet != null)
        {
            Console.WriteLine("Tim thay chi tiet:");
            chiTiet.Xuat();
        }
        else
        {
            Console.WriteLine("Khong tim thay chi tiet voi ma so nay.");
        }
        Console.WriteLine($"So luong chi tiet don: {may.DemChiTietDon()}");
    }
}