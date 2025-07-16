using System;

public class CDiemKhongGian
{
    private float x;
    private float y;
    private float z;

    // Nhóm phương thức khởi tạo
    public CDiemKhongGian()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public CDiemKhongGian(CDiemKhongGian P)
    {
        x = P.x;
        y = P.y;
        z = P.z;
    }

    public CDiemKhongGian(float xx, float yy, float zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }

    public CDiemKhongGian(float xx, float yy)
    {
        x = xx;
        y = yy;
        z = 0;
    }

    public CDiemKhongGian(float xx)
    {
        x = xx;
        y = 0;
        z = 0;
    }

    public void KhoiTao()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public void KhoiTao(CDiemKhongGian P)
    {
        x = P.x;
        y = P.y;
        z = P.z;
    }

    public void KhoiTao(float xx, float yy, float zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }

    public void KhoiTao(float xx, float yy)
    {
        x = xx;
        y = yy;
        z = 0;
    }

    public void KhoiTao(float xx)
    {
        x = xx;
        y = 0;
        z = 0;
    }

    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
        Console.Write("Nhap z: ");
        z = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("(" + x + "," + y + "," + z + ")");
    }

    public float getX()
    {
        return x;
    }

    public float getY()
    {
        return y;
    }

    public float getZ()
    {
        return z;
    }

    public CDiemKhongGian Gan(CDiemKhongGian P)
    {
        x = P.x;
        y = P.y;
        z = P.z;
        return this;
    }

    public void setX(float xx)
    {
        x = xx;
    }

    public void setY(float yy)
    {
        y = yy;
    }

    public void setZ(float zz)
    {
        z = zz;
    }

    public bool ktTrungGoc()
    {
        if (x == 0 && y == 0 && z == 0)
            return true;
        return false;
    }

    public bool ktThuocHoanh()
    {
        if (y == 0 && z == 0)
            return true;
        return false;
    }

    public bool ktThuocTung()
    {
        if (x == 0 && z == 0)
            return true;
        return false;
    }

    public bool ktThuocCao()
    {
        if (x == 0 && y == 0)
            return true;
        return false;
    }

    public bool ktThuocOxy()
    {
        if (z == 0)
            return true;
        return false;
    }

    public bool ktThuocOxz()
    {
        if (y == 0)
            return true;
        return false;
    }

    public bool ktThuocOyz()
    {
        if (x == 0)
            return true;
        return false;
    }

    public bool ktTrung(CDiemKhongGian P)
    {
        if (x == P.x && y == P.y && z == P.z)
            return true;
        return false;
    }

    public bool ktKoTrung(CDiemKhongGian P)
    {
        if (!(x == P.x && y == P.y && z == P.z))
            return true;
        return false;
    }

    public float KhoangCachGoc()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z);
    }

    public float KhoangCachOxy()
    {
        return Math.Abs(z);
    }

    public float KhoangCachOxz()
    {
        return Math.Abs(y);
    }

    public float KhoangCachOyz()
    {
        return Math.Abs(x);
    }

    public float KhoangCach(CDiemKhongGian P)
    {
        return (float)Math.Sqrt((x - P.x) * (x - P.x) + (y - P.y) * (y - P.y) + (z - P.z) * (z - P.z));
    }

    public float KhoangCachX(CDiemKhongGian P)
    {
        return Math.Abs(x - P.x);
    }

    public float KhoangCachY(CDiemKhongGian P)
    {
        return Math.Abs(y - P.y);
    }

    public float KhoangCachZ(CDiemKhongGian P)
    {
        return Math.Abs(z - P.z);
    }

    public CDiemKhongGian DoiXungGoc()
    {
        return new CDiemKhongGian(-x, -y, -z);
    }

    public CDiemKhongGian DoiXungHoanh()
    {
        return new CDiemKhongGian(x, -y, -z);
    }

    public CDiemKhongGian DoiXungTung()
    {
        return new CDiemKhongGian(-x, y, -z);
    }

    public CDiemKhongGian DoiXungCao()
    {
        return new CDiemKhongGian(-x, -y, z);
    }

    public CDiemKhongGian DoiXungOxy()
    {
        return new CDiemKhongGian(x, y, -z);
    }

    public CDiemKhongGian DoiXungOxz()
    {
        return new CDiemKhongGian(x, -y, z);
    }

    public CDiemKhongGian DoiXungOyz()
    {
        return new CDiemKhongGian(-x, y, z);
    }

    ~CDiemKhongGian()
    {
        return;
    }

    public static CDiemKhongGian operator +(CDiemKhongGian A, CDiemKhongGian B)
    => new CDiemKhongGian(A.x + B.x, A.y + B.y, A.z + B.z);


    public static CDiemKhongGian operator -(CDiemKhongGian A, CDiemKhongGian B)
    => new CDiemKhongGian(A.x - B.x, A.y - B.y, A.z - B.z);


    //public void operator +=(CDiemKhongGian A) =>
    //    (x, y, z) =
    //    (
    //        x + A.x,
    //        y + A.y,
    //        z + A.z
    //    );

    //public void operator -=(CDiemKhongGian A) =>
    //    (x, y, z) =
    //    (
    //        x - A.x,
    //        y - A.y,
    //        z - A.z
    //    );

    public static float operator *(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.x * B.x + A.y * B.y + A.z * B.z;
    }

    public static bool operator ==(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.KhoangCachGoc() == B.KhoangCachGoc();
    }

    public static bool operator !=(CDiemKhongGian A, CDiemKhongGian B)
    {
        return !(A == B);
    }

    public static bool operator >(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.KhoangCachGoc() > B.KhoangCachGoc();
    }

    public static bool operator <(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.KhoangCachGoc() < B.KhoangCachGoc();
    }

    public static bool operator >=(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.KhoangCachGoc() >= B.KhoangCachGoc();
    }

    public static bool operator <=(CDiemKhongGian A, CDiemKhongGian B)
    {
        return A.KhoangCachGoc() <= B.KhoangCachGoc();
    }

    //public override bool Equals(object obj)
    //{
    //    if (obj is CDiemKhongGian other)
    //    {
    //        return this == other;
    //    }
    //    return false;
    //}

    //public override int GetHashCode()
    //{
    //    return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
    //}
}
