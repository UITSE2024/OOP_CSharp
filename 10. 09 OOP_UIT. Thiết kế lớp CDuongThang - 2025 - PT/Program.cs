using System;

public class CDiem
{
    private float x;
    private float y;

    public CDiem(float xx = 0, float yy = 0)
    {
        x = xx;
        y = yy;
    }

    public float getX() { return x; }
    public float getY() { return y; }
}

public class CDuongThang
{
    private float a;
    private float b;
    private float c;

    // Nhóm khởi tạo
    public CDuongThang()
    {
        a = 1;
        b = 1;
        c = 1;
    }

    public CDuongThang(CDuongThang d)
    {
        a = d.a;
        b = d.b;
        c = d.c;
    }

    public CDuongThang(float aa, float bb, float cc)
    {
        a = aa;
        b = bb;
        c = cc;
    }

    public CDuongThang(float aa, float bb)
    {
        a = aa;
        b = bb;
        c = 1;
    }

    public CDuongThang(float aa)
    {
        a = aa;
        b = 1;
        c = 1;
    }

    // Nhóm phương thức khởi tạo lại
    public void KhoiTao()
    {
        a = 1;
        b = 1;
        c = 1;
    }

    public void KhoiTao(CDuongThang d)
    {
        a = d.a;
        b = d.b;
        c = d.c;
    }

    public void KhoiTao(float aa, float bb, float cc)
    {
        a = aa;
        b = bb;
        c = cc;
    }

    public void KhoiTao(float aa, float bb)
    {
        a = aa;
        b = bb;
        c = 1;
    }

    public void KhoiTao(float aa)
    {
        a = aa;
        b = 1;
        c = 1;
    }

    // Nhóm cung cấp thông tin
    public float getA()
    {
        return a;
    }
    public float getB()
    {
        return b;
    }
    public float getC()
    {
        return c;
    }

    public void Xuat()
    {
        Console.Write("\n a = " + a);
        Console.Write("\n b = " + b);
        Console.Write("\n c = " + c);
    }

    // Nhóm cập nhật thông tin
    public void setA(float aa)
    {
        a = aa;
    }
    public void setB(float bb)
    {
        b = bb;
    }
    public void setC(float cc)
    {
        c = cc;
    }

    // Nhóm kiểm tra so sánh
    public static bool operator ==(CDuongThang d1, CDuongThang d2)
    {
        return d1.a == d2.a && d1.b == d2.b && d1.c == d2.c;
    }

    public static bool operator !=(CDuongThang d1, CDuongThang d2)
    {
        return !(d1 == d2);
    }

    public static bool operator >(CDuongThang d1, CDuongThang d2)
    {
        return d1.KhoangCachGoc() > d2.KhoangCachGoc();
    }

    public static bool operator <(CDuongThang d1, CDuongThang d2)
    {
        return d1.KhoangCachGoc() < d2.KhoangCachGoc();
    }

    public static bool operator >=(CDuongThang d1, CDuongThang d2)
    {
        return d1.KhoangCachGoc() >= d2.KhoangCachGoc();
    }

    public static bool operator <=(CDuongThang d1, CDuongThang d2)
    {
        return d1.KhoangCachGoc() <= d2.KhoangCachGoc();
    }

    // Nhóm kiểm tra đặc trưng
    public bool ktQuaGoc()
    {
        return c == 0;
    }

    public bool ktSongSongHoanh()
    {
        return a == 0;
    }

    public bool ktSongSongTung()
    {
        return b == 0;
    }

    public bool ktTrung(CDuongThang d)
    {
        return (a * d.b == b * d.a) && (a * d.c == c * d.a) && (b * d.c == c * d.b);
    }

    public bool ktSongSong(CDuongThang d)
    {
        return (a * d.b == b * d.a) && (a * d.c != c * d.a);
    }

    public bool ktCat(CDuongThang d)
    {
        return !ktSongSong(d) && !ktTrung(d);
    }

    public bool ktVuongGoc(CDuongThang d)
    {
        return a * d.a + b * d.b == 0;
    }

    public bool ktThuoc(CDiem p)
    {
        float x = p.getX();
        float y = p.getY();
        return a * x + b * y + c == 0;
    }

    // Nhóm xử lý
    public float KhoangCachGoc()
    {
        return MathF.Abs(c) / MathF.Sqrt(a * a + b * b);
    }

    ~CDuongThang()
    {

    }

    public float KhoangCach(CDuongThang d)
    {
        if (!ktSongSong(d))
            return 0;

        return MathF.Abs(c - d.c) / MathF.Sqrt(a * a + b * b);
    }

    public float KhoangCach(CDiem p)
    {
        float x = p.getX();
        float y = p.getY();
        return MathF.Abs(a * x + b * y + c) / MathF.Sqrt(a * a + b * b);
    }

    public CDiem GiaoDiem(CDuongThang d)
    {
        float D = a * d.b - d.a * b;
        if (D == 0)
            return new CDiem();

        float x = (b * d.c - d.b * c) / D;
        float y = (d.a * c - a * d.c) / D;
        return new CDiem(x, y);
    }
}

class Program
{
    static void Main()
    {

    }
}
