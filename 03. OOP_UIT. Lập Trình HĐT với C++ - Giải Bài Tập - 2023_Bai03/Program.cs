using System;
class CPhanSo
{
    private int Tu;
    private int Mau;
    public void Nhap()
    {
        Console.Write("Nhap tu: ");
        Tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        Mau = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Tu: {0}", Tu);
        Console.WriteLine("Mau: {0}", Mau);
    }
    public int Sosanh(CPhanSo p)
    {
        float a = (float)Tu / Mau;
        float b = (float)p.Tu / p.Mau;
        if (a > b)
            return 1;
        if (a < b)
            return -1;
        return 0;
    }
}
class ClassMain
{
    static void Main()
    {
        CPhanSo a = new CPhanSo();
        CPhanSo b = new CPhanSo();

        Console.WriteLine("Nhap phan so thu nhat: ");
        a.Nhap();
        Console.WriteLine("Nhap phan so thu hai: ");
        b.Nhap();
        int kq = a.Sosanh(b);
        Console.WriteLine("Phan so lon nhat la: ");
        if (kq >= 0)
            a.Xuat();
        else
            b.Xuat();
    }
}
