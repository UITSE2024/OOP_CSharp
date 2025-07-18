using System;

// Class representing a 3D point (CDiemKhongGian)
public class CDiemKhongGian
{
    private float x, y, z; // Coordinates (same as C++ private float x, y, z)

    // Default constructor (C++: CDiemKhongGian())
    public CDiemKhongGian()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    // Copy constructor (C++: CDiemKhongGian(const CDiemKhongGian& P))
    public CDiemKhongGian(CDiemKhongGian P)
    {
        x = P.x;
        y = P.y;
        z = P.z;
    }

    // Parameterized constructor (C++: CDiemKhongGian(float xx, float yy, float zz))
    public CDiemKhongGian(float xx, float yy, float zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }

    // Input method (C++: void Nhap())
    public void Nhap()
    {
        Console.WriteLine();
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine()); // C++: cin >> x
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine()); // C++: cin >> y
        Console.Write("Nhap z: ");
        z = float.Parse(Console.ReadLine()); // C++: cin >> z
    }

    // Output method (C++: void Xuat())
    public void Xuat()
    {
        Console.Write($"({x},{y},{z})"); // C++: cout << "(" << x << "," << y << "," << z << ")"
    }

    // Getters (C++: float getX(), getY(), getZ())
    public float getX()
    {
        return x;
    }

    public float getY()
    {
        return y;
    }

    public float getZ()
    {
        return z;
    }

    // Setters (C++: void setX(float), setY(float), setZ(float))
    public void setX(float xx)
    {
        x = xx;
    }

    public void setY(float yy)
    {
        y = yy;
    }

    public void setZ(float zz)
    {
        z = zz; // Note: C++ has a typo (sets y instead of z), corrected here
    }

    // Assignment operator (C++: CDiemKhongGian& operator=(const CDiemKhongGian&))
    public CDiemKhongGian operator_assign(CDiemKhongGian P) // C# does not support operator=, use method
    {
        x = P.x;
        y = P.y;
        z = P.z;
        return this;
    }

    // Equality operator (C++: bool operator==(CDiemKhongGian))
    public bool operator_equals(CDiemKhongGian P) // C# does not allow operator== for custom types without special handling
    {
        return KhoangCachGoc() == P.KhoangCachGoc(); // Compare distance to origin, as in C++
    }

    // Distance to origin (C++: float KhoangCachGoc())
    public float KhoangCachGoc()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z); // C++: sqrt(x*x + y*y + z*z)
    }

    // Distance to another point (C++: float KhoangCach(const CDiemKhongGian&))
    public float KhoangCach(CDiemKhongGian P)
    {
        return (float)Math.Sqrt(
            (x - P.x) * (x - P.x) +
            (y - P.y) * (y - P.y) +
            (z - P.z) * (z - P.z)); // C++: sqrt((x-P.x)*(x-P.x) + ...)
    }

    // Check if points coincide (C++: bool ktTrung(const CDiemKhongGian&))
    public bool ktTrung(CDiemKhongGian P)
    {
        return x == P.x && y == P.y && z == P.z;
    }

    // Check if points do not coincide (C++: bool ktKoTrung(const CDiemKhongGian&))
    public bool ktKoTrung(CDiemKhongGian P)
    {
        return !(x == P.x && y == P.y && z == P.z);
    }
}

// Class representing a sphere (CHinhCau)
public class CHinhCau
{
    private CDiemKhongGian O; // Center point (same as C++: CDiemKhongGian O)
    private float R; // Radius (same as C++: float R)

    // Default constructor (C++: CHinhCau())
    public CHinhCau()
    {
        O = new CDiemKhongGian();
        R = 1;
    }

    // Copy constructor (C++: CHinhCau(const CHinhCau&))
    public CHinhCau(CHinhCau c)
    {
        O = new CDiemKhongGian(c.O);
        R = c.R;
    }

    // Parameterized constructor (C++: CHinhCau(const CDiemKhongGian&, const float&))
    public CHinhCau(CDiemKhongGian o, float r)
    {
        O = new CDiemKhongGian(o);
        R = r;
    }

    // Input method (C++: void Nhap())
    public void Nhap()
    {
        Console.Write("Nhap tam O: ");
        O.Nhap(); // C++: cin >> O
        Console.Write("Nhap ban kinh R: ");
        R = float.Parse(Console.ReadLine()); // C++: cin >> R
    }

    // Output method (C++: void Xuat())
    public void Xuat()
    {
        Console.WriteLine();
        Console.Write("Tam O: ");
        O.Xuat(); // C++: cout << O
        Console.WriteLine($"\nBan kinh R: {R}"); // C++: cout << R
    }

    // Getters (C++: CDiemKhongGian getO(), float getR())
    public CDiemKhongGian getO()
    {
        return new CDiemKhongGian(O); // Return a copy to prevent modification
    }

    public float getR()
    {
        return R;
    }

    // Setters (C++: void setO(CDiemKhongGian), void setR(float))
    public void setO(CDiemKhongGian OO)
    {
        O = new CDiemKhongGian(OO);
    }

    public void setR(float RR)
    {
        R = RR;
    }

    // Assignment operator (C++: CHinhCau& operator=(const CHinhCau&))
    public CHinhCau operator_assign(CHinhCau c)
    {
        O = new CDiemKhongGian(c.O);
        R = c.R;
        return this;
    }

    // Comparison operators (based on radius, as in C++)
    public bool operator_equals(CHinhCau c) // C++: bool operator==(const CHinhCau&)
    {
        return R == c.R;
    }

    public bool operator_not_equals(CHinhCau c) // C++: bool operator!=(const CHinhCau&)
    {
        return R != c.R;
    }

    public bool operator_greater(CHinhCau c) // C++: bool operator>(const CHinhCau&)
    {
        return R > c.R;
    }

    public bool operator_less(CHinhCau c) // C++: bool operator<(const CHinhCau&)
    {
        return R < c.R;
    }

    public bool operator_greater_equals(CHinhCau c) // C++: bool operator>=(const CHinhCau&)
    {
        return R >= c.R;
    }

    public bool operator_less_equals(CHinhCau c) // C++: bool operator<=(const CHinhCau&)
    {
        return R <= c.R;
    }

    // Geometric checks
    public bool isTiepXucTrong(CHinhCau c) // Internal tangency
    {
        return O.KhoangCach(c.O) == Math.Abs(c.R - R);
    }

    public bool isTiepXucNgoai(CHinhCau c) // External tangency
    {
        return O.KhoangCach(c.O) == Math.Abs(c.R + R);
    }

    public bool isNamTrong(CHinhCau c) // This sphere inside c
    {
        return O.KhoangCach(c.O) < Math.Abs(c.R - R);
    }

    public bool isNamNgoai(CHinhCau c) // This sphere outside c
    {
        return O.KhoangCach(c.O) > Math.Abs(c.R + R);
    }

    public bool isGiaoNhau(CHinhCau c) // Intersection
    {
        float kc = O.KhoangCach(c.O);
        return kc > Math.Abs(c.R - R) && kc < Math.Abs(c.R + R);
    }

    public bool isNamTrong(CDiemKhongGian P) // Point inside sphere
    {
        return O.KhoangCach(P) < R;
    }

    public bool isNamNgoai(CDiemKhongGian P) // Point outside sphere
    {
        return O.KhoangCach(P) > R;
    }

    public bool isNamTren(CDiemKhongGian P) // Point on sphere surface
    {
        return O.KhoangCach(P) == R;
    }

    public bool ktTrung(CHinhCau c) // Spheres coincide
    {
        return O.ktTrung(c.O) && R == c.R;
    }

    public bool ktKhongTrung(CHinhCau c) // Spheres do not coincide
    {
        return !ktTrung(c);
    }

    // Calculations
    public float DienTichXungQuanh() // Surface area
    {
        return 4 * (float)Math.PI * R * R; // C++: 4 * 3.14 * R * R
    }

    public float TheTich() // Volume
    {
        return (4.0f / 3) * (float)Math.PI * R * R * R; // C++: (4.0f / 3) * 3.14 * R * R * R
    }
}

// Main program for testing (not in original files, added for completeness)
public class Program
{
    public static void Main(string[] args)
    {
        CHinhCau sphere1 = new CHinhCau();
        Console.WriteLine("Nhap hinh cau thu nhat:");
        sphere1.Nhap();

        CHinhCau sphere2 = new CHinhCau();
        Console.WriteLine("\nNhap hinh cau thu hai:");
        sphere2.Nhap();

        Console.WriteLine("\nHinh cau thu nhat:");
        sphere1.Xuat();
        Console.WriteLine($"\nDien tich xung quanh: {sphere1.DienTichXungQuanh()}");
        Console.WriteLine($"The tich: {sphere1.TheTich()}");

        Console.WriteLine("\nHinh cau thu hai:");
        sphere2.Xuat();
        Console.WriteLine($"\nDien tich xung quanh: {sphere2.DienTichXungQuanh()}");
        Console.WriteLine($"The tich: {sphere2.TheTich()}");

        Console.WriteLine("\nKiem tra vi tri tuong doi:");
        Console.WriteLine($"Tiep xuc trong: {sphere1.isTiepXucTrong(sphere2)}");
        Console.WriteLine($"Tiep xuc ngoai: {sphere1.isTiepXucNgoai(sphere2)}");
        Console.WriteLine($"Nam trong: {sphere1.isNamTrong(sphere2)}");
        Console.WriteLine($"Nam ngoai: {sphere1.isNamNgoai(sphere2)}");
        Console.WriteLine($"Giao nhau: {sphere1.isGiaoNhau(sphere2)}");
        Console.WriteLine($"Trung nhau: {sphere1.ktTrung(sphere2)}");
        Console.WriteLine($"Khong trung nhau: {sphere1.ktKhongTrung(sphere2)}");
    }
}