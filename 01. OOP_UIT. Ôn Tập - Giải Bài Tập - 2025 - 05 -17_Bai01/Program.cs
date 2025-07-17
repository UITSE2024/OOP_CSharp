using System;
struct PHANSO
{
    public int Tu;
    public int Mau;
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
    public int XetDau()
    {
        if (Tu * Mau > 0)
            return 1;
        if (Tu * Mau < 0)
            return -1;
        return 0;
    }
}
class ClassMain
{
    static void Main()
    {
        PHANSO a = new PHANSO();
        a.Nhap();
        a.Xuat();
        int kq = a.XetDau();
        switch (kq)
        {
            case 1:
                Console.WriteLine("Phan so > 0");
                break;
            case -1:
                Console.WriteLine("Phan so < 0");
                break;
            case 0:
                Console.WriteLine("Phan so = 0");
                break;
        }
    }
}
