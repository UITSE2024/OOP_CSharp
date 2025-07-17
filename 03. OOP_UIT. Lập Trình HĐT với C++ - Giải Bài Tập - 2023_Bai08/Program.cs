using System;
class CDiem
{
    private float x;
    private float y;
    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("x= {0}", x);
        Console.WriteLine("y= {0}", y);
    }
    public float KhoangCach(CDiem Q)
    {
        return (float)Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y));
    }
    public float LayX()
    {
        return x;
    }
    public float LayY()
    {
        return y;
    }
    public void CapNhapX(float xx)
    {
        x = xx;
    }
    public void CapNhapY(float yy)
    {
        y = yy;
    }
}
class CTamGiac
{
    private CDiem A;
    private CDiem B;
    private CDiem C;
    public void Nhap()
    {
        A = new CDiem();
        B = new CDiem();
        C = new CDiem();
        Console.WriteLine("Nhap A: ");
        A.Nhap();
        Console.WriteLine("Nhap B: ");
        B.Nhap();
        Console.WriteLine("Nhap C: ");
        C.Nhap();
    }
    public void Xuat()
    {
        Console.WriteLine("A: ");
        A.Xuat();
        Console.WriteLine("B: ");
        B.Xuat();
        Console.WriteLine("C: ");
        C.Xuat();
    }
    public float Chuvi()
    {
        float a = B.KhoangCach(C);
        float b = A.KhoangCach(C);
        float c = A.KhoangCach(B);
        return a + b + c;
    }
    public float Dientich()
    {
        float a = B.KhoangCach(C);
        float b = A.KhoangCach(C);
        float c = A.KhoangCach(B);
        float p = (a + b + c) / 2;
        return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public CDiem TrongTam()
    {
        CDiem temp = new CDiem();
        temp.CapNhapX((A.LayX() + B.LayX() + C.LayX()) / 3);
        temp.CapNhapY((A.LayY() + B.LayY() + C.LayY()) / 3);
        return temp;
    }
}
class ClassMain
{
    static void Main()
    {
        CTamGiac tg = new CTamGiac();
        tg.Nhap();
        tg.Xuat();
        float cv = tg.Chuvi();
        Console.WriteLine("Chu vi: {0}", cv);
        float dt = tg.Dientich();
        Console.WriteLine("Dien tich: {0}", dt);
        CDiem G = tg.TrongTam();
        Console.WriteLine("Trong tam: ");
        G.Xuat();
    }
}
