using System;
struct DIEM
{
    public float x;
    public float y;
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
    public float KhoangCach(DIEM Q)
    {
        return (float)Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y));
    }
}
struct TAMGIAC
{
    public DIEM A;
    public DIEM B;
    public DIEM C;
    public void Nhap()
    {
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
    public DIEM TrongTam()
    {
        DIEM temp;
        temp.x = (A.x + B.x + C.x) / 3;
        temp.y = (A.y + B.y + C.y) / 3;
        return temp;
    }
}
class ClassMain
{
    static void Main()
    {
        TAMGIAC tg = new TAMGIAC();
        tg.Nhap();
        tg.Xuat();
        float cv = tg.Chuvi();
        Console.WriteLine("Chu vi: {0}", cv);
        float dt = tg.Dientich();
        Console.WriteLine("Dien tich: {0}", dt);
        DIEM G = tg.TrongTam();
        Console.WriteLine("Trong tam: ");
        G.Xuat();
    }
}
