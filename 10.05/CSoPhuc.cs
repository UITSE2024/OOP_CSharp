using System;

public class CSoPhuc
{
    private float Thuc;
    private float Ao;

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public CSoPhuc()
    {
        Thuc = 0;
        Ao = 0;
    }

    public CSoPhuc(CSoPhuc x)
    {
        Thuc = x.Thuc;
        Ao = x.Ao;
    }

    public CSoPhuc(float ThucThuc, float AoAo)
    {
        Thuc = ThucThuc;
        Ao = AoAo;
    }

    public CSoPhuc(float ThucThuc)
    {
        Thuc = ThucThuc;
        Ao = 0;
    }

    public void KhoiTao()
    {
        Thuc = 0;
        Ao = 0;
    }

    public void KhoiTao(CSoPhuc x)
    {
        Thuc = x.Thuc;
        Ao = x.Ao;
    }

    public void KhoiTao(float ThucThuc, float AoAo)
    {
        Thuc = ThucThuc;
        Ao = AoAo;
    }

    public void KhoiTao(float ThucThuc)
    {
        Thuc = ThucThuc;
        Ao = 0;
    }

    public void Nhap()
    {
        Console.Write("Nhap phan thuc: ");
        Thuc = float.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        Ao = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine(Thuc + "+" + Ao + "i");
    }

    public float GetThuc()
    {
        return Thuc;
    }

    public float GetAo()
    {
        return Ao;
    }

    public void SetThuc(float ThucThuc)
    {
        Thuc = ThucThuc;
    }

    public void SetAo(float AoAo)
    {
        Ao = AoAo;
    }

    public CSoPhuc Gan(CSoPhuc x)
    {
        Thuc = x.Thuc;
        Ao = x.Ao;
        return this;
    }

    public bool ktThuanAo()
    {
        return Thuc == 0;
    }

    public bool ktThuanThuc()
    {
        return Ao == 0;
    }

    public float Module()
    {
        return (float)Math.Sqrt(Thuc * Thuc + Ao * Ao);
    }

    public CSoPhuc LienHop()
    {
        return new CSoPhuc(Thuc, -Ao);
    }

    public CSoPhuc Tong(CSoPhuc x)
    {
        return new CSoPhuc(Thuc + x.Thuc, Ao + x.Ao);
    }

    public CSoPhuc Hieu(CSoPhuc x)
    {
        return new CSoPhuc(Thuc - x.Thuc, Ao - x.Ao);
    }

    public CSoPhuc Tich(CSoPhuc x)
    {
        float thuc = Thuc * x.Thuc - Ao * x.Ao;
        float ao = Thuc * x.Ao + Ao * x.Thuc;
        return new CSoPhuc(thuc, ao);
    }

    public CSoPhuc Thuong(CSoPhuc x)
    {
        float mau = x.Thuc * x.Thuc + x.Ao * x.Ao;
        float thuc = (Thuc * x.Thuc + Ao * x.Ao) / mau;
        float ao = (Ao * x.Thuc - Thuc * x.Ao) / mau;
        return new CSoPhuc(thuc, ao);
    }

    public static CSoPhuc operator +(CSoPhuc a, CSoPhuc b)
    {
        return new CSoPhuc(a.Thuc + b.Thuc, a.Ao + b.Ao);
    }

    public static CSoPhuc operator -(CSoPhuc a, CSoPhuc b)
    {
        return new CSoPhuc(a.Thuc - b.Thuc, a.Ao - b.Ao);
    }

    public static CSoPhuc operator *(CSoPhuc a, CSoPhuc b)
    {
        return new CSoPhuc(a.Thuc * b.Thuc - a.Ao * b.Ao, a.Thuc * b.Ao + a.Ao * b.Thuc);
    }

    public static CSoPhuc operator /(CSoPhuc a, CSoPhuc b)
    {
        float mau = b.Thuc * b.Thuc + b.Ao * b.Ao;
        float thuc = (a.Thuc * b.Thuc + a.Ao * b.Ao) / mau;
        float ao = (a.Ao * b.Thuc - a.Thuc * b.Ao) / mau;
        return new CSoPhuc(thuc, ao);
    }

    public static CSoPhuc operator ++(CSoPhuc a)
    {
        a.Thuc++;
        return a;
    }

    public static CSoPhuc operator --(CSoPhuc a)
    {
        a.Thuc--;
        return a;
    }

    public CSoPhuc LuyThua(int n)
    {
        CSoPhuc temp = new CSoPhuc(1, 0);
        for (int i = 1; i <= n; i++)
        {
            temp *= this;
        }
        return temp;
    }

    public CSoPhuc LuyThuaBang(int n)
    {
        CSoPhuc temp = new CSoPhuc(1, 0);
        for (int i = 1; i <= n; i++)
        {
            temp *= this;
        }
        this.Gan(temp);
        return this;
    }

    public override bool Equals(object obj)
    {
        if (obj is CSoPhuc other)
        {
            return Module() == other.Module();
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Thuc.GetHashCode() ^ Ao.GetHashCode();
    }

    public static bool operator ==(CSoPhuc a, CSoPhuc b)
    {
        return a.Module() == b.Module();
    }

    public static bool operator !=(CSoPhuc a, CSoPhuc b)
    {
        return !(a == b);
    }

    public static bool operator >(CSoPhuc a, CSoPhuc b)
    {
        return a.Module() > b.Module();
    }

    public static bool operator <(CSoPhuc a, CSoPhuc b)
    {
        return a.Module() < b.Module();
    }

    public static bool operator >=(CSoPhuc a, CSoPhuc b)
    {
        return a.Module() >= b.Module();
    }

    public static bool operator <=(CSoPhuc a, CSoPhuc b)
    {
        return a.Module() <= b.Module();
    }
}
