using System;
class CSoPhuc
{
    private float Thuc;
    private float Ao;

    public void Nhap()
    {
        Console.WriteLine("Nhap thuc: ");
        Thuc = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ao: ");
        Ao = float.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Thuc = {0}", Thuc);
        Console.WriteLine("Ao = {0}", Ao);
    }
    public CSoPhuc Tong(CSoPhuc x)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = Thuc + x.Thuc;
        temp.Ao = Ao + x.Ao;
        return temp;
    }
    public CSoPhuc Hieu(CSoPhuc x)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = Thuc - x.Thuc;
        temp.Ao = Ao - x.Ao;
        return temp;
    }
    public CSoPhuc Tich(CSoPhuc x)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = Thuc * x.Thuc - Ao * x.Ao;
        temp.Ao = Thuc * x.Ao - Ao * x.Thuc;
        return temp;
    }
}
class ClassMain
{
    static void Main()
    {
        CSoPhuc a = new CSoPhuc();
        CSoPhuc b = new CSoPhuc();
        CSoPhuc kq;
        Console.WriteLine("Nhap so phuc thu nhat: ");
        a.Nhap();
        Console.WriteLine("Nhap so phuc thu hai: ");
        b.Nhap();

        Console.WriteLine("Tong hai so phuc: ");
        kq = a.Tong(b);
        kq.Xuat();

        Console.WriteLine("Hieu hai so phuc: ");
        kq = a.Hieu(b);
        kq.Xuat();

        Console.WriteLine("Tich hai so phuc: ");
        kq = a.Tich(b);
        kq.Xuat();
    }
}
