using System;
using _10._10.OOP_UIT.Thiết_kế_lớp_CDuongTron;

class CDuongTron
{
    private CDiem I;
    private float R;

    // Nhom phuong thuc thiet lap
    public CDuongTron()
    {
        this.I = new CDiem(0f, 0f);
        this.R = 0f;
    }

    public CDuongTron(CDuongTron other)
    {
        this.R = other.R;
        this.I = other.I;
    }

    public CDuongTron(CDiem II, float RR)
    {
        this.R = RR;
        this.I = II;
    }

    public CDuongTron(CDiem II)
    {
        this.R = 0;
        this.I = II;
    }

    public CDuongTron(float RR)
    {
        this.R = RR;
        this.I = new CDiem(0, 0);
    }

    //Nhom phuong thuc khoi tao

    public void KhoiTao()
    {
        this.I = new CDiem(0f, 0f);
        this.R = 0f;
    }

    public void KhoiTao(CDuongTron other)
    {
        this.I = other.I;
        this.R = other.R;
    }

    public void KhoiTao(float RR)
    {
        this.R = RR;
        this.I = new CDiem(0, 0);
    }

    public void KhoiTao(CDiem II)
    {
        this.R = 0;
        this.I = II;
    }

    public void KhoiTao(float RR, CDiem II)
    {
        this.R = RR;
        this.I = II;
    }

    public void Nhap()
    {
        Console.Write("Nhap R: ");
        this.R = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhap I: ");
        this.I.Nhap();
    }

    public void Xuat()
    {
        Console.Write("Toa do tam: ");
        this.I.Xuat();
        Console.WriteLine($"Ban kinh R: {this.R}");
    }

    public CDiem II
    {
        get { return this.I; }
        set { this.I = value; }
    }

    public float RR
    {
        get { return this.R; }
        set { this.R = value; }
    }

    public static bool operator ==(CDuongTron dt1, CDuongTron dt2)
    {
        return dt1.R == dt2.R;
    }

    public static bool operator !=(CDuongTron dt1, CDuongTron dt2)
    {
        return !(dt1 == dt2);
    }

    public static bool operator >(CDuongTron dt1, CDuongTron dt2)
    {
        return dt1.R > dt2.R;
    }

    public static bool operator <(CDuongTron dt1, CDuongTron dt2)
    {
        return dt1.R < dt2.R;
    }

    public static bool operator >=(CDuongTron dt1, CDuongTron dt2)
    {
        return dt1.R >= dt2.R;
    }

    public static bool operator <=(CDuongTron dt1, CDuongTron dt2)
    {
        return dt1.R <= dt2.R;
    }

    public bool ktQuaGoc()
    {
        return I.KhoangCachGoc() == R;
    }

    public bool ktChuaGoc()
    {
        return I.KhoangCachGoc() <= R;
    }

    public bool ktTiepXucHoanh()
    {
        return R == Math.Abs(I.X);
    }

    public bool ktTiepXucTung()
    {
        return R == Math.Abs(I.Y);
    }

    public bool ktPhanTu1()
    {
        return R <= Math.Abs(I.X) && R <= Math.Abs(I.Y) && I.ktThuoc1() ;
    }

    public bool ktPhanTu2()
    {
        return R <= Math.Abs(I.X) && R <= Math.Abs(I.Y) && I.ktThuoc2();
    }

    public bool ktPhanTu3()
    {
        return R <= Math.Abs(I.X) && R <= Math.Abs(I.Y) && I.ktThuoc3();
    }

    public bool ktPhanTu4()
    {
        return R <= Math.Abs(I.X) && R <= Math.Abs(I.Y) && I.ktThuoc4();
    }

    public bool ktTrung(CDuongTron c)
    {
        return this.I == c.I && this.R == c.R;
    }

    public bool ktDonVi()
    {
        CDiem goc = new CDiem();
        CDuongTron temp = new CDuongTron(goc, 1);
        return ktTrung(temp);
    }

    public bool ktCat(CDuongTron c)
    {
        float kc = I.KhoangCach(c.I);
        return (R - c.R) < kc && kc < (R + c.R);
    }

    public bool ktTiepXucTrong(CDuongTron c)
    {
        float kc = I.KhoangCach(c.I);
        return Math.Abs(R - c.R) == kc;
    }

    public bool ktTiepXucNgoai(CDuongTron c)
    {
        float kc = I.KhoangCach(c.I);
        return Math.Abs(R + c.R) == kc;
    }

    public bool ktNamTrong(CDuongTron c)
    {
        float kc = I.KhoangCach(c.I);
        return Math.Abs(R - c.R) < kc;
    }

    public bool ktNamNgoai(CDuongTron c)
    {
        float kc = I.KhoangCach(c.I);
        return Math.Abs(R - c.R) > kc;
    }

    public bool ktDongTam(CDuongTron c)
    {
        return this.I == c.I;
    }

    ~CDuongTron()
    { return; }

    public float KhoangCachGoc()
    {
        return Math.Abs(I.KhoangCachGoc() - R);
    }

    public float ChuVi()
    {
        return (float) Math.PI * 2 * R;
    }

    public float DienTich()
    {
        return (float)Math.PI * R * R;
    }

    public float DienTichPhu(CDuongTron c)
    {
        float s1 = (float)(Math.Pow(R, 2) * Math.PI);
        float s2 = (float)(Math.Pow(c.R, 2) * Math.PI);
        return s1 + s2 - DienTichGiao(c);
    }

    public float DienTichGiao(CDuongTron c)
    {
        float S1 = (float)(Math.Pow(R, 2) * Math.PI);
        float S2 = (float)(Math.Pow(c.R, 2) * Math.PI);
        float d = I.KhoangCach(c.I);

        float cos1 = (float)((Math.Pow(R, 2) + Math.Pow(d, 2) - Math.Pow(c.R, 2)) / (2 * R * d));
        float S11 = (float)((Math.Acos(cos1) * S1) / Math.PI);

        float I1H = R * cos1;
        float MH = (float)Math.Sqrt(Math.Pow(R, 2) - Math.Pow(I1H, 2));
        float S111 = MH * I1H;
        float SGiao1 = S11 - S111;

        float cos2 = (float)((Math.Pow(c.R, 2) + Math.Pow(d, 2) - Math.Pow(R, 2)) / (2 * c.R * d));
        float S22 = (float)((Math.Acos(cos2) * S2) / Math.PI);
        float I2H = c.R * cos2;
        float S222 = MH * I2H;
        float SGiao2 = S22 - S222;

        return SGiao2 + SGiao1;


    }




}
internal class CDiem
{
    float x;
    float y;

    public CDiem(float x = 0f, float y = 0f)
    {
        this.x = x;
        this.y = y;
    }

    public void Nhap()
    {
        
        this.x = Convert.ToSingle(Console.ReadLine());
        this.y = Convert.ToSingle(Console.ReadLine());

    }

    public void Xuat()
    {
        Console.WriteLine($"({this.x}, {this.y})");
    }

    public float KhoangCachGoc()
    {
        return (float) Math.Sqrt(x * x + y * y);
    }

    public float X
    {
        get { return x; }
        set { x = value; }
    }

    public float Y
    {
        get { return y; }
        set { y = value; }
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

    public float KhoangCach(CDiem A)
    {
        return (float)Math.Sqrt((x - A.x) * (x - A.x) + (y - A.y) * (y - A.y));
    }

    public static bool operator == (CDiem A, CDiem B)
    {
        return A.x == B.x && A.y == B.y;
    }

    public static bool operator !=(CDiem A, CDiem B)
    {
        return !(A == B);
    }
}


