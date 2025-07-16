using System;

public class CTamGiac
{
    private CDiem A;
    private CDiem B;
    private CDiem C;

    // === NHÓM KHỞI TẠO ===
    public CTamGiac()
    {
        A = new CDiem();
        B = new CDiem();
        C = new CDiem();
    }

    public CTamGiac(CTamGiac t)
    {
        A = new CDiem(t.A);
        B = new CDiem(t.B);
        C = new CDiem(t.C);
    }

    public CTamGiac(CDiem a, CDiem b, CDiem c)
    {
        A = new CDiem(a);
        B = new CDiem(b);
        C = new CDiem(c);
    }

    public CTamGiac(CDiem a, CDiem b)
    {
        A = new CDiem(a);
        B = new CDiem(b);
        C = new CDiem();
    }

    public CTamGiac(CDiem a)
    {
        A = new CDiem(a);
        B = new CDiem();
        C = new CDiem();
    }

    public void KhoiTao()
    {
        A = new CDiem();
        B = new CDiem();
        C = new CDiem();
    }

    public void KhoiTao(CTamGiac t)
    {
        A = new CDiem(t.A);
        B = new CDiem(t.B);
        C = new CDiem(t.C);
    }

    public void KhoiTao(CDiem a, CDiem b, CDiem c)
    {
        A = new CDiem(a);
        B = new CDiem(b);
        C = new CDiem(c);
    }

    public void KhoiTao(CDiem a, CDiem b)
    {
        A = new CDiem(a);
        B = new CDiem(b);
        C = new CDiem();
    }

    public void KhoiTao(CDiem a)
    {
        A = new CDiem(a);
        B = new CDiem();
        C = new CDiem();
    }

    public void Nhap()
    {
        Console.WriteLine("Nhap A:");
        A.Nhap();
        Console.WriteLine("Nhap B:");
        B.Nhap();
        Console.WriteLine("Nhap C:");
        C.Nhap();
    }

    public void Xuat()
    {
        Console.Write("\nDiem A vua nhap: "); A.Xuat();
        Console.Write("\nDiem B vua nhap: "); B.Xuat();
        Console.Write("\nDiem C vua nhap: "); C.Xuat();
    }

    public CDiem getA() { return A; }
    public CDiem getB() { return B; }
    public CDiem getC() { return C; }

    public void setA(CDiem a) { A = new CDiem(a); }
    public void setB(CDiem b) { B = new CDiem(b); }
    public void setC(CDiem c) { C = new CDiem(c); }

    public void setA(float x, float y) { A.setX(x); A.setY(y); }
    public void setB(float x, float y) { B.setX(x); B.setY(y); }
    public void setC(float x, float y) { C.setX(x); C.setY(y); }

    public static bool operator ==(CTamGiac t1, CTamGiac t2) => t1.DienTich() == t2.DienTich();
    public static bool operator !=(CTamGiac t1, CTamGiac t2) => t1.DienTich() != t2.DienTich();
    public static bool operator >(CTamGiac t1, CTamGiac t2) => t1.DienTich() > t2.DienTich();
    public static bool operator <(CTamGiac t1, CTamGiac t2) => t1.DienTich() < t2.DienTich();
    public static bool operator >=(CTamGiac t1, CTamGiac t2) => t1.DienTich() >= t2.DienTich();
    public static bool operator <=(CTamGiac t1, CTamGiac t2) => t1.DienTich() <= t2.DienTich();

    public bool ktHopLe()
    {
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        return a + b > c && a + c > b && b + c > a;
    }

    public bool ktDeu()
    {
        if (!ktHopLe()) return false;
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        return a == b && b == c;
    }

    public bool ktCan()
    {
        if (!ktHopLe()) return false;
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        return a == b || b == c || c == a;
    }

    public bool ktVuong()
    {
        if (!ktHopLe()) return false;
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        return a * a + b * b == c * c || c * c + b * b == a * a || a * a + c * c == b * b;
    }

    public bool ktVuongCan()
    {
        return ktHopLe() && ktVuong() && ktCan();
    }

    public bool ktTrung(CTamGiac t)
    {
        return A == t.A && B == t.B && C == t.C;
    }

    public bool ktKoTrung(CTamGiac t)
    {
        return !ktTrung(t);
    }

    public float ChuVi()
    {
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        return a + b + c;
    }

    public float DienTich()
    {
        float a = B.KhoangCach(C);
        float b = C.KhoangCach(A);
        float c = A.KhoangCach(B);
        float p = (a + b + c) / 2;
        return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public CDiem TrongTam()
    {
        return new CDiem((A.getX() + B.getX() + C.getX()) / 3, (A.getY() + B.getY() + C.getY()) / 3);
    }

    public CDiem TrucTam()
    {
        float d1A = C.getX() - B.getX();
        float d1B = C.getY() - B.getY();
        float d1C = A.getX() * d1A + A.getY() * d1B;

        float d2A = C.getX() - A.getX();
        float d2B = C.getY() - A.getY();
        float d2C = B.getX() * d2A + B.getY() * d2B;

        float dd = d1A * d2B - d1B * d2A;
        float dx = d1C * d2B - d1B * d2C;
        float dy = d1A * d2C - d1C * d2A;

        return new CDiem(dx / dd, dy / dd);
    }

    public static CTamGiac operator +(CTamGiac a, CTamGiac b)
    {
        return new CTamGiac(a.A + b.A, a.B + b.B, a.C + b.C);
    }

    public static CTamGiac operator -(CTamGiac a, CTamGiac b)
    {
        return new CTamGiac(a.A - b.A, a.B - b.B, a.C - b.C);
    }

    // Ghi đè Equals & GetHashCode nếu cần sử dụng trong HashSet, Dictionary, v.v.
    public override bool Equals(object obj)
    {
        if (obj is CTamGiac t)
            return this == t;
        return false;
    }

    public override int GetHashCode()
    {
        return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
    }
}
