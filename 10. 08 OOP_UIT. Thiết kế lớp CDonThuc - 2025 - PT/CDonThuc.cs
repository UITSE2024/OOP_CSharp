using System;

public class CDonThuc
{
    private float a;
    private int n;

    // === NHÓM KHỞI TẠO ===
    public CDonThuc()
    {
        a = 0;
        n = 0;
    }

    public CDonThuc(CDonThuc f)
    {
        a = f.a;
        n = f.n;
    }

    public CDonThuc(float aa, int nn)
    {
        a = aa;
        n = nn;
    }

    public CDonThuc(float aa)
    {
        a = aa;
        n = 0;
    }

    public CDonThuc(int nn)
    {
        a = 0;
        n = nn;
    }

    public void KhoiTao()
    {
        a = 0;
        n = 0;
    }

    public void KhoiTao(CDonThuc f)
    {
        a = f.a;
        n = f.n;
    }

    public void KhoiTao(float aa, int nn)
    {
        a = aa;
        n = nn;
    }

    public void KhoiTao(float aa)
    {
        a = aa;
        n = 0;
    }

    public void KhoiTao(int nn)
    {
        a = 0;
        n = nn;
    }

    public void Nhap()
    {
        Console.Write("Nhap he so: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Nhap mu: ");
        n = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        if (n == 0)
            Console.Write("(" + a + ")");
        else
            Console.Write("(" + a + ")x^" + n);
    }

    public float getHeSo()
    {
        return a;
    }

    public int getSoMu()
    {
        return n;
    }

    public void setHeSo(float aa)
    {
        a = aa;
    }

    public void setSoMu(int nn)
    {
        n = nn;
    }

    public bool ktDonThucKhong()
    {
        return a == 0;
    }

    public static CDonThuc operator *(CDonThuc f1, CDonThuc f2)
    {
        return new CDonThuc(f1.a * f2.a, f1.n + f2.n);
    }

    public static CDonThuc operator /(CDonThuc f1, CDonThuc f2)
    {
        return new CDonThuc(f1.a / f2.a, f1.n - f2.n);
    }
    public CDonThuc Tich(CDonThuc f)
    {
        return new CDonThuc(a * f.a, n + f.n);
    }

    public CDonThuc Thuong(CDonThuc f)
    {
        return new CDonThuc(a / f.a, n - f.n);
    }

    public CDonThuc DaoHam()
    {
        if (n == 0)
        {
            return new CDonThuc(0, 0);
        }
        return new CDonThuc(a * n, n - 1);
    }

    public CDonThuc DaoHam(int k)
    {
        CDonThuc temp = new CDonThuc(this);
        for (int i = 1; i <= k; i++)
        {
            temp = temp.DaoHam();
        }
        return temp;
    }

    public CDonThuc NguyenHam()
    {
        return new CDonThuc(a / (n + 1), n + 1);
    }

    public CDonThuc NguyenHam(int k)
    {
        CDonThuc temp = new CDonThuc(this);
        for (int i = 1; i <= k; i++)
        {
            temp = temp.NguyenHam();
        }
        return temp;
    }

    public static bool operator ==(CDonThuc f1, CDonThuc f2)
    {
        return f1.a == f2.a && f1.n == f2.n;
    }

    public static bool operator !=(CDonThuc f1, CDonThuc f2)
    {
        return !(f1 == f2);
    }

    public static bool operator >(CDonThuc f1, CDonThuc f2)
    {
        if (f1.n > f2.n) return true;
        if (f1.n < f2.n) return false;
        return f1.a > f2.a;
    }

    public static bool operator <(CDonThuc f1, CDonThuc f2)
    {
        if (f1.n < f2.n) return true;
        if (f1.n > f2.n) return false;
        return f1.a < f2.a;
    }

    public static bool operator >=(CDonThuc f1, CDonThuc f2)
    {
        return !(f1 < f2);
    }

    public static bool operator <=(CDonThuc f1, CDonThuc f2)
    {
        return !(f1 > f2);
    }
}
