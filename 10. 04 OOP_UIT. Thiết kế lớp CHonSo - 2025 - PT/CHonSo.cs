using System;
using System.Runtime.CompilerServices;

public class CHonSo
{
    private int Nguyen;
    private int Tu;
    private int Mau;

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public CHonSo()
    {
        Nguyen = 0;
        Tu = 0;
        Mau = 1;
    }

    public CHonSo(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public CHonSo(int NguyenNguyen, int TuTu, int MauMau)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = MauMau;
    }

    public CHonSo(int NguyenNguyen, int TuTu)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = 1;
    }

    public CHonSo(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
        Tu = 0;
        Mau = 1;
    }

    public void KhoiTao()
    {
        Nguyen = 0;
        Tu = 0;
        Mau = 1;
    }

    public void KhoiTao(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public void KhoiTao(int NguyenNguyen, int TuTu, int MauMau)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = MauMau;
    }

    public void KhoiTao(int NguyenNguyen, int TuTu)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = 1;
    }

    public void KhoiTao(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
        Tu = 0;
        Mau = 1;
    }

    public void Nhap()
    {
        Console.Write("Nhap phan nguyen: ");
        Nguyen = int.Parse(Console.ReadLine());
        Console.Write("Nhap tu: ");
        Tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        Mau = int.Parse(Console.ReadLine());
    }

    // === NHÓM PHƯƠNG THỨC CUNG CẤP THÔNG TIN ===
    public void Xuat()
    {
        if (Nguyen == 0)
            Console.WriteLine(Tu + "/" + Mau);
        else
            Console.WriteLine(Nguyen + " " + Tu + "/" + Mau);
    }

    public override string ToString()
    {
        if (Nguyen == 0)
            return Tu + "/" + Mau;
        else
            return Nguyen + " " + Tu + "/" + Mau;
    }

    public int getNguyen()
    {
        return Nguyen;
    }
    public int getTu()
    {
        return Tu;
    }
    public int getMau()
    {
        return Mau;
    }

    public float getGiaTri()
    {
        return Nguyen + (float)Tu / Mau;
    }

    // === NHÓM PHƯƠNG THỨC CẬP NHẬT THÔNG TIN ===
    public void setNguyen(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
    }

    public void setTu(int TuTu)
    {
        Tu = TuTu;
    }

    public void setMau(int MauMau)
    {
        Mau = MauMau;
    }

    public CHonSo Gan(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
        return this;
    }

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public bool Equals(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a == b)
            return true;

        return false;
    }
    public bool NotEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a != b)
            return true;

        return false;
    }

    public static bool operator > (CHonSo a, CHonSo b)
    {
        float aa = a.getGiaTri();
        float bb = b.getGiaTri();
        if (aa > bb)
            return true;

        return false;
    }

    public static bool operator < (CHonSo a, CHonSo b)
    {
        float aa = a.getGiaTri();
        float bb = b.getGiaTri();
        if (aa < bb)
            return true;

        return false;
    }

    public static bool operator >= (CHonSo a, CHonSo b)
    {
        float aa = a.getGiaTri();
        float bb = b.getGiaTri();
        if (aa >= bb)
            return true;

        return false;
    }
    public static bool operator <=(CHonSo a, CHonSo b)
    {
        float aa = a.getGiaTri();
        float bb = b.getGiaTri();
        if (aa <= bb)
            return true;

        return false;
    }

    public bool isCoNghia()
    {
        if (Mau != 0)
            return true;

        return false;
    }

    public bool isToiGian()
    {
        if (UCLN() != 1)
            return false;

        if (Tu / Mau >= 1)
            return false;

        return true;
    }

    public bool isKhong()
    {
        if (getGiaTri() == 0)
            return true;

        return false;
    }

    public bool isDuong()
    {
        if (getGiaTri() > 0)
            return true;

        return false;
    }

    public bool isAm()
    {
        if (getGiaTri() < 0)
            return true;

        return false;
    }

    // === NHÓM PHƯƠNG THỨC XỬ LÝ ===

    ~CHonSo()
    {
        return;
    }

    public static CHonSo operator +(CHonSo a, CHonSo b)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen + b.Nguyen;
        result.Tu = a.Tu * b.Mau + b.Tu * a.Mau;
        result.Mau = a.Mau * b.Mau;
        result.RutGon();
        return result;
    }

    public static CHonSo operator -(CHonSo a, CHonSo b)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen - b.Nguyen;
        result.Tu = a.Tu * b.Mau - b.Tu * a.Mau;
        result.Mau = a.Mau * b.Mau;
        result.RutGon();
        return result;
    }

    public static CHonSo operator *(CHonSo a, CHonSo b)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen * b.Nguyen;
        result.Tu = a.Tu * b.Tu + a.Nguyen * b.Tu * b.Mau + b.Nguyen * a.Tu * a.Mau;
        result.Mau = a.Mau * b.Mau;
        result.RutGon();
        return result;
    }

    public static CHonSo operator /(CHonSo a, CHonSo b)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen / b.Nguyen;
        result.Tu = a.Tu * b.Mau;
        result.Mau = a.Mau * b.Tu;
        result.RutGon();
        return result;
    }

    public static CHonSo operator ++ (CHonSo a)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen + 1;
        result.Tu = a.Tu;
        result.Mau = a.Mau;
        result.RutGon();
        return result;
    }

    public static CHonSo operator -- (CHonSo a)
    {
        CHonSo result = new CHonSo();
        result.Nguyen = a.Nguyen - 1;
        result.Tu = a.Tu;
        result.Mau = a.Mau;
        result.RutGon();
        return result;
    }


    public int UCLN()
    {
        int a = Math.Abs(Tu);
        int b = Math.Abs(Mau);

        while (a * b != 0)
        {
            if (a > b) 
                a %= b;
            else 
                b %= a;
        }
        return a + b;
    }

    public void RutGonPhanSo()
    {
        int temp = UCLN();
        Tu /= temp;
        Mau /= temp;
    }

    public void RutGon()
    {
        RutGonPhanSo();
        Nguyen += Tu / Mau;
        Tu %= Mau;
    }

    public int XetDau()
    {
        float temp = getGiaTri();
        if (temp > 0) 
            return 1;
        if (temp < 0) 
            return -1;
        return 0;
    }
}
