using System;

public class CPhanSo
{
    private int Tu;
    private int Mau;

    // Nhóm khởi tạo
    public CPhanSo()
    {
        Tu = 0;
        Mau = 1;
    }

    public CPhanSo(CPhanSo x)
    {
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public CPhanSo(int TuTu, int MauMau)
    {
        Tu = TuTu;
        Mau = MauMau;
    }

    public CPhanSo(int TuTu)
    {
        Tu = TuTu;
        Mau = 1;
    }

    public void KhoiTao()
    {
        Tu = 0;
        Mau = 1;
    }

    public void KhoiTao(CPhanSo x)
    {
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public void KhoiTao(int TuTu, int MauMau)
    {
        Tu = TuTu;
        Mau = MauMau;
    }

    public void KhoiTao(int TuTu)
    {
        Tu = TuTu;
        Mau = 1;
    }

    public void Nhap()
    {
        Console.Write("Nhap tu: ");
        Tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        Mau = int.Parse(Console.ReadLine());
    }

    // Nhóm cung cấp thông tin
    public void Xuat()
    {
        Console.WriteLine($"{Tu}/{Mau}");
    }

    public int getTu()
    {
        return Tu;
    }

    public int getMau()
    {
        return Mau;
    }

    public float getGiaTri()
    {
        return (float)Tu / Mau;
    }

    // Nhóm cập nhật thông tin

    public void setTu(int TuTu)
    {
        Tu = TuTu;
    }

    public void setMau(int MauMau)
    {
        Mau = MauMau;
    }

    // Nhóm kiểm tra
    public static bool operator ==(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = a - b;
        return temp.Tu == 0;
    }

    public static bool operator !=(CPhanSo a, CPhanSo b)
    {
        return !(a == b);
    }

    public static bool operator >(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = a - b;
        return (temp.Tu * temp.Mau > 0);
    }

    public static bool operator <(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = a - b;
        return (temp.Tu * temp.Mau < 0);
    }

    public static bool operator >=(CPhanSo a, CPhanSo b)
    {
        return a > b || a == b;
    }

    public static bool operator <=(CPhanSo a, CPhanSo b)
    {
        return a < b || a == b;
    }

    public bool ktCoNghia()
    {
        if (Mau != 0)
            return true;
        return false;
    }

    public bool ktToiGian()
    {
        if (UCLN() == 1)
            return true;
        return false;
    }

    public bool ktDuong()
    {
        if (Tu * Mau > 0)
            return true;
        return false;
    }

    public bool ktAm()
    {
        if (Tu * Mau < 0)
            return true;
        return false;
    }

    public bool ktKhong()
    {
        if (Tu == 0)
            return true;
        return false;
    }

    // Nhóm xử lý
    ~CPhanSo()
    {

    }

    public static CPhanSo operator +(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau + a.Mau * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        temp.RutGon();
        return temp;
    }

    public static CPhanSo operator -(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        temp.RutGon();
        return temp;
    }

    public static CPhanSo operator *(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Tu;
        temp.Mau = a.Mau * b.Mau;
        temp.RutGon();
        return temp;
    }

    public static CPhanSo operator /(CPhanSo a, CPhanSo b)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = a.Tu * b.Mau;
        temp.Mau = a.Mau * b.Tu;
        temp.RutGon();
        return temp;
    }

    public static CPhanSo operator ^(CPhanSo a, int n)
    {
        CPhanSo temp = new CPhanSo(1, 1);
        for (int i = 1; i <= n; i++)
            temp *= a;
        temp.RutGon();
        return temp;
    }

    //Khong can nap chong cac toan tu +=, -=, *=, /=, ^= vi cac toan tu nay duoc suy ra tu cac toan tu +, -, *, /, ^

    public CPhanSo Tich(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Tu;
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        return temp;
    }

    public CPhanSo Thuong(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau;
        temp.Mau = Mau * x.Tu;
        temp.RutGon();
        return temp;
    }

    public CPhanSo Tong(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau + Mau * x.Tu;
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        return temp;
    }

    public CPhanSo Hieu(CPhanSo x)
    {
        CPhanSo temp = new CPhanSo();
        temp.Tu = Tu * x.Mau - Mau * x.Tu;
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        return temp;
    }

    //Chi co the nap chong toan tu ++, -- prefix
    public static CPhanSo operator ++(CPhanSo a)
    {
        a.Tu = a.Tu + a.Mau;
        return a;
    }

    public static CPhanSo operator --(CPhanSo a)
    {
        a.Tu = a.Tu - a.Mau;
        return a;
    }

    public void RutGon()
    {
        int ucln = UCLN();
        Tu = Tu / ucln;
        Mau = Mau / ucln;
    }

    public int UCLN()
    {
        int a = Math.Abs(Tu);
        int b = Math.Abs(Mau);
        while (a * b != 0)
        {
            if (a > b)
                a = a % b;
            else
                b = b % a;
        }
        return a + b;
    }

    public int XetDau()
    {
        if (Tu * Mau < 0)
            return -1;
        if (Tu == 0)
            return 0;
        return 1;
    }
}

class Program
{
    static void Main()
    {

    }
}
