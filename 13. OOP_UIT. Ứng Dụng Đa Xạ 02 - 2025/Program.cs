using System;
using System.Collections.Generic;

public class CNgay
{
    private int ngay;
    private int thang;
    private int nam;

    public void Nhap()
    {
        Console.Write("Nhap ngay: ");
        ngay = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        nam = int.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"{ngay}/{thang}/{nam}";
    }
}

public abstract class CNhanVien
{
    protected string hoTen;
    protected CNgay ngaySinh = new CNgay();
    protected float luong;
    protected float luongCoBan;

    public virtual void Nhap() { }
    public virtual void TinhLuong() { }
    public virtual void Xuat() { }
    public virtual float LayLuong() => luong;
    public virtual CNhanVien TimKiem(string tuKhoa)
    {
        return hoTen == tuKhoa ? this : null;
    }
}

public class CNhanVienQuanLy : CNhanVien
{
    private float heSoChucVu;
    private float thuong;

    public override void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.WriteLine("Nhap ngay sinh:");
        ngaySinh.Nhap();
        Console.Write("Nhap luong co ban: ");
        luongCoBan = float.Parse(Console.ReadLine());
        Console.Write("Nhap he so chuc vu: ");
        heSoChucVu = float.Parse(Console.ReadLine());
        Console.Write("Nhap tien thuong: ");
        thuong = float.Parse(Console.ReadLine());
    }

    public override void TinhLuong()
    {
        luong = luongCoBan * heSoChucVu + thuong;
    }

    public override void Xuat()
    {
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Ngay sinh: {ngaySinh}");
        Console.WriteLine($"Luong co ban: {luongCoBan}");
        Console.WriteLine($"He so chuc vu: {heSoChucVu}");
        Console.WriteLine($"Tien thuong: {thuong}");
        Console.WriteLine($"Luong: {luong}");
    }
}

public class CNhanVienSanXuat : CNhanVien
{
    private int soSanPham;

    public override void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.WriteLine("Nhap ngay sinh:");
        ngaySinh.Nhap();
        Console.Write("Nhap luong co ban: ");
        luongCoBan = float.Parse(Console.ReadLine());
        Console.Write("Nhap so san pham: ");
        soSanPham = int.Parse(Console.ReadLine());
    }

    public override void TinhLuong()
    {
        luong = luongCoBan + soSanPham * 2000;
    }

    public override void Xuat()
    {
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Ngay sinh: {ngaySinh}");
        Console.WriteLine($"Luong co ban: {luongCoBan}");
        Console.WriteLine($"So san pham: {soSanPham}");
        Console.WriteLine($"Luong: {luong}");
    }
}

public class CNhanVienVanPhong : CNhanVien
{
    private int soNgayLamViec;
    private float troCap;

    public override void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.WriteLine("Nhap ngay sinh:");
        ngaySinh.Nhap();
        Console.Write("Nhap luong co ban: ");
        luongCoBan = float.Parse(Console.ReadLine());
        Console.Write("Nhap so ngay lam viec: ");
        soNgayLamViec = int.Parse(Console.ReadLine());
        Console.Write("Nhap tro cap: ");
        troCap = float.Parse(Console.ReadLine());
    }

    public override void TinhLuong()
    {
        luong = luongCoBan + soNgayLamViec * 100000 + troCap;
    }

    public override void Xuat()
    {
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Ngay sinh: {ngaySinh}");
        Console.WriteLine($"Luong co ban: {luongCoBan}");
        Console.WriteLine($"So ngay lam viec: {soNgayLamViec}");
        Console.WriteLine($"Tro cap: {troCap}");
        Console.WriteLine($"Luong: {luong}");
    }
}

public class CCongTy
{
    private int n;
    private CNhanVien[] ds = new CNhanVien[100];

    public void Nhap()
    {
        Console.Write("Nhap so luong nhan vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap nhan vien thu {i + 1}:");
            Console.Write("Nhap loai nhan vien (0. San xuat, 1. Van phong, 2. Quan ly): ");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 0: ds[i] = new CNhanVienSanXuat(); break;
                case 1: ds[i] = new CNhanVienVanPhong(); break;
                case 2: ds[i] = new CNhanVienQuanLy(); break;
            }

            ds[i].Nhap();
        }
    }

    public void TinhLuong()
    {
        for (int i = 0; i < n; i++)
            ds[i].TinhLuong();
    }

    public void Xuat()
    {
        Console.WriteLine("\nDanh sach cac nhan vien:");
        for (int i = 0; i < n; i++)
            ds[i].Xuat();
    }

    public float TongLuong()
    {
        float tong = 0;
        for (int i = 0; i < n; i++)
            tong += ds[i].LayLuong();
        return tong;
    }

    public CNhanVien TimKiem(string hoTen)
    {
        for (int i = 0; i < n; i++)
        {
            CNhanVien kq = ds[i].TimKiem(hoTen);
            if (kq != null)
                return kq;
        }
        return null;
    }
}

public class Program
{
    public static void Main()
    {
        CCongTy CT = new CCongTy();
        CT.Nhap();
        CT.TinhLuong();
        CT.Xuat();

        Console.WriteLine($"Tong luong cong ty la: {CT.TongLuong()}");

        Console.Write("Nhap ho ten nhan vien can tim: ");
        string ht = Console.ReadLine();

        CNhanVien kq = CT.TimKiem(ht);
        if (kq != null)
        {
            Console.WriteLine("Tim thay!!!");
            kq.Xuat();
        }
        else
        {
            Console.WriteLine("Khong tim thay!!!");
        }
    }
}
