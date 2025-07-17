using System;

public class CHonSo
{
    private int Nguyen;
    private int Tu;
    private int Mau;

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public CHonSo()
    {
        Nguyen = 0;
        Tu = 0;
        Mau = 1;
    }

    public CHonSo(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public CHonSo(int NguyenNguyen, int TuTu, int MauMau)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = MauMau;
    }

    public CHonSo(int NguyenNguyen, int TuTu)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = 1;
    }

    public CHonSo(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
        Tu = 0;
        Mau = 1;
    }

    public void KhoiTao()
    {
        Nguyen = 0;
        Tu = 0;
        Mau = 1;
    }

    public void KhoiTao(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
    }

    public void KhoiTao(int NguyenNguyen, int TuTu, int MauMau)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = MauMau;
    }

    public void KhoiTao(int NguyenNguyen, int TuTu)
    {
        Nguyen = NguyenNguyen;
        Tu = TuTu;
        Mau = 1;
    }

    public void KhoiTao(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
        Tu = 0;
        Mau = 1;
    }

    // === NHÓM PHƯƠNG THỨC CUNG CẤP THÔNG TIN ===
    public void Xuat()
    {
        if (Nguyen == 0)
            Console.WriteLine(Tu + "/" + Mau);
        else
            Console.WriteLine(Nguyen + " " + Tu + "/" + Mau);
    }

    public override string ToString()
    {
        if (Nguyen == 0)
            return Tu + "/" + Mau;
        else
            return Nguyen + " " + Tu + "/" + Mau;
    }

    public int getNguyen()
    {
        return Nguyen;
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
        return Nguyen + (float)Tu / Mau;
    }

    // === NHÓM PHƯƠNG THỨC CẬP NHẬT THÔNG TIN ===
    public void setNguyen(int NguyenNguyen)
    {
        Nguyen = NguyenNguyen;
    }

    public void setTu(int TuTu)
    {
        Tu = TuTu;
    }

    public void setMau(int MauMau)
    {
        Mau = MauMau;
    }

    public CHonSo Gan(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
        return this;
    }

    // === NHÓM PHƯƠNG THỨC KHỞI TẠO ===
    public bool Equals(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a == b)
            return true;

        return false;
    }
    public bool NotEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a != b)
            return true;

        return false;
    }

    public bool GreaterThan(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a > b)
            return true;

        return false;
    }

    public bool LessThan(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a < b)
            return true;

        return false;
    }

    public bool GreaterThanOrEqual(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a >= b)
            return true;

        return false;
    }
    public bool LessThanOrEqual(CHonSo x)
    {
        CHonSo temp = new CHonSo(x);
        float a = getGiaTri();
        float b = temp.getGiaTri();
        if (a <= b)
            return true;

        return false;
    }

    public bool isCoNghia()
    {
        if (Mau != 0)
            return true;

        return false;
    }

    public bool isToiGian()
    {
        if (UCLN() != 1)
            return false;

        if (Tu / Mau >= 1)
            return false;

        return true;
    }

    public bool isKhong()
    {
        if (getGiaTri() == 0)
            return true;

        return false;
    }

    public bool isDuong()
    {
        if (getGiaTri() > 0)
            return true;

        return false;
    }

    public bool isAm()
    {
        if (getGiaTri() < 0)
            return true;

        return false;
    }

    // === NHÓM PHƯƠNG THỨC XỬ LÝ ===

    ~CHonSo()
    {
        return;
    }

    public CHonSo Add (CHonSo x)
    {
        var result = new CHonSo();
        result.Nguyen = Nguyen + x.Nguyen;
        result.Tu = Tu * x.Mau + Mau * x.Tu;
        result.Mau = Mau * x.Mau;
        result.RutGon();
        return result;
    }

    public CHonSo Subtract(CHonSo x)
    {
        var result = new CHonSo();
        result.Nguyen = Nguyen - x.Nguyen;
        result.Tu = Tu * x.Mau - Mau * x.Tu;
        result.Mau = Mau * x.Mau;
        result.RutGon();
        return result;
    }

    public CHonSo Multiply(CHonSo x)
    {
        var result = new CHonSo();
        result.Tu = (Nguyen * Mau + Tu) * (x.Nguyen * x.Mau + x.Tu);
        result.Mau = Mau * x.Mau;
        result.RutGon();
        return result;
    }

    public CHonSo Divide(CHonSo x)
    {
        var result = new CHonSo();
        result.Tu = (Nguyen * Mau + Tu) * x.Mau;
        result.Mau = Mau * (x.Nguyen * x.Mau + x.Tu);
        result.RutGon();
        return result;
    }

    public CHonSo AddEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo();
        temp.Nguyen = Nguyen + x.Nguyen;
        temp.Tu = Tu * x.Mau + Mau * x.Tu;
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        this.Gan(temp);
        return this;
    }
    public CHonSo SubEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo();
        temp.Nguyen = Nguyen - x.Nguyen;
        temp.Tu = Tu * x.Mau - Mau * x.Tu;
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        this.Gan(temp);
        return this;
    }

    public CHonSo MulEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo();
        temp.Tu = (Nguyen * Mau + Tu) * (x.Nguyen * x.Mau + x.Tu);
        temp.Mau = Mau * x.Mau;
        temp.RutGon();
        this.Gan(temp);
        return this;
    }

    public CHonSo DivEquals(CHonSo x)
    {
        CHonSo temp = new CHonSo();
        temp.Tu = (Nguyen * Mau + Tu) * x.Mau;
        temp.Mau = Mau * (x.Nguyen * x.Mau + x.Tu);
        temp.RutGon();
        this.Gan(temp);
        return this;
    }

    public CHonSo Increment()
    {
        Nguyen++;
        return this;
    }
    public CHonSo Decrement()
    {
        Nguyen--;
        return this;
    }

    public CHonSo Increment(int value)
    {
        Nguyen += value;
        return this;
    }

    public CHonSo Decrement(int value)
    {
        Nguyen -= value;
        return this;
    }


    // Utility
    public int UCLN()
    {
        int a = Math.Abs(Tu);
        int b = Math.Abs(Mau);

        while (a * b != 0)
        {
            if (a > b) 
                a %= b;
            else 
                b %= a;
        }
        return a + b;
    }

    public void RutGonPhanSo()
    {
        int temp = UCLN();
        Tu /= temp;
        Mau /= temp;
    }

    public void RutGon()
    {
        RutGonPhanSo();
        Nguyen += Tu / Mau;
        Tu %= Mau;
    }

    public int XetDau()
    {
        float temp = getGiaTri();
        if (temp > 0) 
            return 1;
        if (temp < 0) 
            return -1;
        return 0;
    }
}
