using System;

public class CDiem
{
    private float x;
    private float y;

    // === NHÓM KHỞI TẠO ===
    public CDiem()
    {
        x = 0;
        y = 0;
    }

    public CDiem(CDiem P)
    {
        x = P.x;
        y = P.y;
    }

    public CDiem(float xx, float yy)
    {
        x = xx;
        y = yy;
    }

    public CDiem(float xx)
    {
        x = xx;
        y = 0;
    }

    public void KhoiTao()
    {
        x = 0;
        y = 0;
    }

    public void KhoiTao(CDiem P)
    {
        x = P.x;
        y = P.y;
    }

    public void KhoiTao(float xx, float yy)
    {
        x = xx;
        y = yy;
    }

    public void KhoiTao(float xx)
    {
        x = xx;
        y = 0;
    }

    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.Write("(" + x + "," + y + ")");
    }

    public float getX()
    {
        return x;
    }

    public float getY()
    {
        return y;
    }

    public void setX(float xx)
    {
        x = xx;
    }

    public void setY(float yy)
    {
        y = yy;
    }

    public static bool operator ==(CDiem P1, CDiem P2)
    {
        return P1.KhoangCachGoc() == P2.KhoangCachGoc();
    }

    public static bool operator !=(CDiem P1, CDiem P2)
    {
        return !(P1 == P2);
    }

    public static bool operator >(CDiem P1, CDiem P2)
    {
        return P1.KhoangCachGoc() > P2.KhoangCachGoc();
    }

    public static bool operator <(CDiem P1, CDiem P2)
    {
        return P1.KhoangCachGoc() < P2.KhoangCachGoc();
    }

    public static bool operator >=(CDiem P1, CDiem P2)
    {
        return P1.KhoangCachGoc() >= P2.KhoangCachGoc();
    }

    public static bool operator <=(CDiem P1, CDiem P2)
    {
        return P1.KhoangCachGoc() <= P2.KhoangCachGoc();
    }

    public bool ktTrungGoc()
    {
        return x == 0 && y == 0;
    }

    public bool ktThuocHoanh()
    {
        return y == 0;
    }

    public bool ktThuocTung()
    {
        return x == 0;
    }

    public bool ktThuoc1()
    {
        return x > 0 && y > 0;
    }

    public bool ktThuoc2()
    {
        return x < 0 && y > 0;
    }

    public bool ktThuoc3()
    {
        return x < 0 && y < 0;
    }

    public bool ktThuoc4()
    {
        return x > 0 && y < 0;
    }

    public bool ktTrung(CDiem P)
    {
        return x == P.x && y == P.y;
    }

    public bool ktKoTrung(CDiem P)
    {
        return !(x == P.x && y == P.y);
    }

    public static CDiem operator +(CDiem P1, CDiem P2)
    {
        return new CDiem(P1.x + P2.x, P1.y + P2.y);
    }

    public static CDiem operator -(CDiem P1, CDiem P2)
    {
        return new CDiem(P1.x - P2.x, P1.y - P2.y);
    }

    public static float operator *(CDiem P1, CDiem P2)
    {
        return P1.x * P2.x + P1.y * P2.y;
    }

    public float KhoangCachGoc()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }

    public float KhoangCachHoanh()
    {
        return Math.Abs(y);
    }

    public float KhoangCachTung()
    {
        return Math.Abs(x);
    }

    public float KhoangCach(CDiem P)
    {
        return (float)Math.Sqrt((x - P.x) * (x - P.x) + (y - P.y) * (y - P.y));
    }

    public float KhoangCachX(CDiem P)
    {
        return Math.Abs(x - P.x);
    }

    public float KhoangCachY(CDiem P)
    {
        return Math.Abs(y - P.y);
    }

    public CDiem DoiXungGoc()
    {
        return new CDiem(-x, -y);
    }

    public CDiem DoiXungHoanh()
    {
        return new CDiem(x, -y);
    }

    public CDiem DoiXungTung()
    {
        return new CDiem(-x, y);
    }

    public CDiem DoiXungPhanGiac1()
    {
        return new CDiem(y, x);
    }

    public CDiem DoiXungPhanGiac2()
    {
        return new CDiem(-y, -x);
    }

    // Ghi đè Equals & GetHashCode nếu cần sử dụng trong HashSet, Dictionary, v.v.
    public override bool Equals(object obj)
    {
        if (obj is CDiem d)
            return this == d;
        return false;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() ^ y.GetHashCode();
    }
}
