using System;

class CPhanSo
{
    private int Tu;
    private int Mau;

    public CPhanSo()
    {
        Tu = 0;
        Mau = 1;
        Console.WriteLine("Constructor mac dinh duoc goi");
    }

    public CPhanSo(int TuTu, int MauMau)
    {
        Tu = TuTu;
        Mau = MauMau;
        Console.WriteLine("Constructor co doi so duoc goi");
    }

    public CPhanSo(CPhanSo x)
    {
        Tu = x.Tu;
        Mau = x.Mau;
        Console.WriteLine("Constructor sao chep duoc goi");
    }

    ~CPhanSo()
    {
        //Destructor can chu y
        Console.WriteLine("Destructor duoc goi");
    }

    public void Xuat()
    {
        Console.WriteLine($"Phan so: {Tu}/{Mau}");
    }
}

class Program
{
    static void Main()
    {
        CPhanSo a = new CPhanSo();
        CPhanSo b = new CPhanSo(3, 4);
        CPhanSo c = new CPhanSo(b);

        a.Xuat();
        b.Xuat();
        c.Xuat();
    }
}