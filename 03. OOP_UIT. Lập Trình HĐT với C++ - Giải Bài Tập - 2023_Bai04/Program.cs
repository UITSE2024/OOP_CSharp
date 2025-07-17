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
    public CPhanSo Tong(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau + x.Tu * Mau;
        temp.Mau = Mau * x.Mau;
        return temp;
    }
    public CPhanSo Hieu(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau - x.Tu * Mau;
        temp.Mau = Mau * x.Mau;
        return temp;
    }
    public CPhanSo Tich(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Tu;
        temp.Mau = Mau * x.Mau;
        return temp;
    }
    public CPhanSo Thuong(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau;
        temp.Mau = Mau * x.Tu;
        return temp;
    }
}
class ClassMain
{
    static int Main()
    {
        CPhanSo a = new CPhanSo();
        CPhanSo b = new CPhanSo();

        Console.WriteLine("Nhap phan so thu nhat: ");
        a.Nhap();
        Console.WriteLine("Nhap phan so thu hai: ");
        b.Nhap();
        CPhanSo kq = new CPhanSo();

        kq = a.Tong(b);
        Console.WriteLine("Tong hai phan so: ");
        kq.Xuat();

        kq = a.Hieu(b);
        Console.WriteLine("Hieu hai phan so: ");
        kq.Xuat();

        kq = a.Tich(b);
        Console.WriteLine("Tich hai phan so: ");
        kq.Xuat();

        kq = a.Thuong(b);
        Console.WriteLine("Thuong hai phan so: ");
        kq.Xuat();

        return 0;
    }
}
