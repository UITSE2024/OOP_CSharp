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
}
struct CDuongTron
{
    public CDiem I;
    public float R;

    public void Nhap()
    {
        Console.WriteLine("Nhap tam: ");
        I = new CDiem();
        I.Nhap();
        Console.WriteLine("Nhap ban kinh: ");
        R = float.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Tam: {0}", I);
        Console.WriteLine("Ban kinh: {0}", R);
    }
    public float ChuVi()
    {
        return (float)(2 * 3.14 * R);
    }
    public float DienTich()
    {
        return (float)3.14 * R * R;
    }
}
class ClassMain()
{
    static void Main()
    {
        CDuongTron c = new CDuongTron();
        c.Nhap();
        c.Xuat();
        float cv = c.ChuVi();
        Console.WriteLine("Chu vi: {0}", cv);
        float dt = c.DienTich();
        Console.WriteLine("Dien tich: {0}", dt);
    }
}