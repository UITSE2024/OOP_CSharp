using System;
struct DIEMKHONGGIAN
{
    public float x;
    public float y;
    public float z;
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
    public double KhoangCach(DIEMKHONGGIAN Q)
    {
        return Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y) + (z - Q.z) * (z - Q.z));
    }
}
class Classmain
{
    static void Main()
    {
        DIEMKHONGGIAN A = new DIEMKHONGGIAN();
        DIEMKHONGGIAN B = new DIEMKHONGGIAN();
        A.Nhap();
        B.Nhap();
        double kq = A.KhoangCach(B);
        A.Xuat();
        B.Xuat();
        Console.WriteLine("Ket qua = {0}", kq);
    }
}

