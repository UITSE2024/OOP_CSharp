using System;
class CDiemKhongGian
{
    private float x;
    private float y;
    private float z;
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
        Console.WriteLine("x= {0}", x);
        Console.WriteLine("y= {0}", y);
        Console.WriteLine("z= {0}", z);
    }
    public double KhoangCach(CDiemKhongGian Q)
    {
        return Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y) + (z - Q.z) * (z - Q.z));
    }
}
class Classmain
{
    static void Main()
    {
        CDiemKhongGian A = new CDiemKhongGian();
        CDiemKhongGian B = new CDiemKhongGian();
        A.Nhap();
        B.Nhap();
        double kq = A.KhoangCach(B);
        A.Xuat();
        B.Xuat();
        Console.WriteLine("Ket qua = {0}", kq);
    }
}
