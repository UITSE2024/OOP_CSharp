using System;
class CDiem
{
    private double X { get; set; }
    private double Y { get; set; }
    public CDiem()
    {
        X = Y = 0;
    }
    public CDiem(double x, double y)
    {
        X = x;
        Y = y;
    }
    public CDiem(CDiem A)
    {
        X = A.X;
        Y = A.Y;
    }
    public CDiem(CDiem A, CDiem B)
    {
        X = A.X + B.X;
        Y = A.Y + B.Y;
    }
    public double KhoangCachTuGoc()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap x:\n");
        X = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap y:\n");
        Y = double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"({X}, {Y})");
    }
    public bool KTtrunggoc()
    {
        return X == 0 && Y == 0;
    }
    public static bool operator ==(CDiem A, CDiem B)
    {
        return A.X == B.X && A.Y == B.Y;
    }
    public static bool operator !=(CDiem A, CDiem B)
    {
        return !(A == B);
    }
    public static bool operator >(CDiem A, CDiem B)
    {
        double OA = A.KhoangCachTuGoc();
        double OB = B.KhoangCachTuGoc();
        return OA > OB;
    }
    public static bool operator <(CDiem A, CDiem B)
    {
        double OA = A.KhoangCachTuGoc();
        double OB = B.KhoangCachTuGoc();
        return OA < OB;
    }
    public static bool operator >=(CDiem A, CDiem B)
    {
        double OA = A.KhoangCachTuGoc();
        double OB = B.KhoangCachTuGoc();
        return OA >= OB;
    }
    public static bool operator <=(CDiem A, CDiem B)
    {
        double OA = A.KhoangCachTuGoc();
        double OB = B.KhoangCachTuGoc();
        return OA <= OB;
    }
    public string KTGocPhanTu()
    {
        if (X > 0 && Y > 0) return "I";
        if (X < 0 && Y > 0) return "II";
        if (X < 0 && Y < 0) return "III";
        return "IV";
    }
    public static bool KT2Diemtrungnhau(CDiem A, CDiem B)
    {
        return A.X == B.X && A.Y == B.Y;
    }
    public static bool KT2Diemkhongtrungnhau(CDiem A, CDiem B)
    {
        return !(KT2Diemtrungnhau(A, B));
    }
    public static CDiem operator +(CDiem A, CDiem B)
    {
        return new CDiem(A.X + B.X, A.Y + B.Y);
    }
    public static CDiem operator *(CDiem A, CDiem B)
    {
        return new CDiem(A.X * B.X, A.Y * B.Y);
    }
    public static CDiem operator -(CDiem A, CDiem B)
    {
        return new CDiem(A.X - B.X, A.Y - B.Y);
    }


    ~CDiem()
    {
        Console.WriteLine("Phuong thuc huy da duoc goi");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap diem A:");
        CDiem A = new CDiem();
        A.Nhap();
        Console.Write("Toa do diem A: ");
        A.Xuat();

        Console.WriteLine("Nhap diem B:");
        CDiem B = new CDiem();
        B.Nhap();
        Console.Write("Toa do diem B: ");
        B.Xuat();

        Console.WriteLine($"A == B? {A == B}");
        Console.WriteLine($"A != B? {A != B}");
        Console.WriteLine($"A va B trung nhau? {CDiem.KT2Diemtrungnhau(A, B)}");
        Console.WriteLine($"A va B khong trung nhau? {CDiem.KT2Diemkhongtrungnhau(A, B)}");

        Console.WriteLine($"A > B? {A > B}");
        Console.WriteLine($"A < B? {A < B}");
        Console.WriteLine($"A >= B? {A >= B}");
        Console.WriteLine($"A <= B? {A <= B}");

        CDiem Tong = A + B;
        CDiem Hieu = A - B;
        CDiem Tich = A * B;

        Console.Write("A + B = ");
        Tong.Xuat();

        Console.Write("A - B = ");
        Hieu.Xuat();

        Console.Write("A * B = ");
        Tich.Xuat();

        Console.WriteLine($"A co la goc toa do? {A.KTtrunggoc()}");
        Console.WriteLine($"B co la goc toa do? {B.KTtrunggoc()}");

        Console.WriteLine($"A thuoc goc phan tu: {A.KTGocPhanTu()}");
        Console.WriteLine($"B thuoc goc phan tu: {B.KTGocPhanTu()}");

        CDiem C = new CDiem(A);
        Console.Write("Diem C (sao chep tu A): ");
        C.Xuat();

        CDiem D = new CDiem(A, B);
        Console.Write("Diem D (A + B bang constructor): ");
        D.Xuat();

        Console.WriteLine($"Khoang cach tu O den A: {A.KhoangCachTuGoc():F2}");
        Console.WriteLine($"Khoang cach tu O den B: {B.KhoangCachTuGoc():F2}");

        Console.WriteLine("Chuong trinh ket thuc.");
    }
}

