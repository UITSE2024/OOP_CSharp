using System;
using System.Collections.Generic;

// Abstract base class CLuuTru (similar to C++: class CLuuTru { virtual void Nhap() = 0; })
public abstract class CLuuTru
{
    // Properties (like C++ private members with getters/setters)
    protected string Ten { get; set; } // Name of the storage object (string in C++, std::string)
    protected DateTime NgayTaoLap { get; set; } // Creation date (C# DateTime, unlike string/struct in C++)

    // Input method (virtual in C++, allows overriding)
    public virtual void Nhap()
    {
        Console.Write("Nhap ten: "); // Like C++: cout << "Nhap ten: ";
        Ten = Console.ReadLine(); // Like C++: getline(cin, Ten);
        Console.Write("Nhap ngay tao lap (dd/MM/yyyy): ");
        NgayTaoLap = DateTime.Parse(Console.ReadLine()); // Parse string to DateTime, no direct C++ equivalent
    }

    // Output method (virtual in C++)
    public virtual void Xuat()
    {
        Console.WriteLine($"Ten: {Ten}, Ngay tao lap: {NgayTaoLap:dd/MM/yyyy}"); // Like C++: cout << "Ten: " << Ten << ...
    }

    // Calculate size (virtual, overridden by derived classes)
    public virtual float TinhDungLuong()
    {
        return 0; // Base class returns 0, overridden in derived classes
    }

    // Count files (virtual, overridden)
    public virtual int DemTapTin()
    {
        return 0; // Base class returns 0
    }

    // Count directories (virtual, overridden)
    public virtual int DemThuMuc()
    {
        return 0; // Base class returns 0
    }
}

// File class, inherits from CLuuTru (like C++: class CTapTin : public CLuuTru)
public class CTapTin : CLuuTru
{
    protected float DungLuong { get; set; } // File size in MB (like float in C++)

    // Override Nhap to include size input
    public override void Nhap()
    {
        base.Nhap(); // Call base class Nhap (like C++: CLuuTru::Nhap())
        Console.Write("Nhap dung luong (MB): ");
        DungLuong = float.Parse(Console.ReadLine()); // Like C++: cin >> DungLuong
    }

    // Override Xuat to include size
    public override void Xuat()
    {
        base.Xuat(); // Call base class Xuat
        Console.WriteLine($"Dung luong: {DungLuong} MB"); // Like C++: cout << "Dung luong: " << DungLuong
    }

    // Return file size
    public override float TinhDungLuong()
    {
        return DungLuong; // Return the file's size
    }

    // Count this file as 1
    public override int DemTapTin()
    {
        return 1; // A file counts as 1
    }
}

// Directory class, inherits from CLuuTru (like C++: class CThuMuc : public CLuuTru)
public class CThuMuc : CLuuTru
{
    protected int n; // Number of storage objects (like int n in C++)
    protected List<CLuuTru> ds; // Dynamic list (like C++: vector<CLuuTru*> ds)

    // Constructor to initialize the list (like C++ constructor)
    public CThuMuc()
    {
        ds = new List<CLuuTru>(); // Initialize empty list (like C++: vector<CLuuTru*>())
    }

    // Override Nhap to input directory contents
    public override void Nhap()
    {
        base.Nhap(); // Call base class Nhap
        Console.Write("Nhap so luong doi tuong luu tru: ");
        n = int.Parse(Console.ReadLine()); // Like C++: cin >> n
        ds.Clear(); // Clear the list (like C++: ds.clear())
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap doi tuong luu tru [{i}] (0: Tap tin, 1: Thu muc): ");
            int type = int.Parse(Console.ReadLine()); // Read type (0 for file, 1 for directory)
            CLuuTru temp; // Polymorphic object (like C++: CLuuTru* temp)
            if (type == 0)
                temp = new CTapTin(); // Create file (like C++: new CTapTin())
            else
                temp = new CThuMuc(); // Create directory (like C++: new CThuMuc())
            temp.Nhap(); // Input details (polymorphic call)
            ds.Add(temp); // Add to list (like C++: ds.push_back(temp))
        }
    }

    // Override Xuat to output directory contents
    public override void Xuat()
    {
        base.Xuat(); // Call base class Xuat
        Console.WriteLine($"So luong doi tuong luu tru: {n}");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Doi tuong luu tru [{i}]:");
            ds[i].Xuat(); // Polymorphic output
        }
    }

    // Calculate total size of directory
    public override float TinhDungLuong()
    {
        float s = 0;
        foreach (var luuTru in ds) // Like C++: for (CLuuTru* luuTru : ds)
        {
            s += luuTru.TinhDungLuong(); // Sum sizes of components
        }
        return s;
    }

    // Count total files in directory
    public override int DemTapTin()
    {
        int count = 0;
        foreach (var luuTru in ds)
        {
            count += luuTru.DemTapTin(); // Recursive count
        }
        return count;
    }

    // Count total directories (including this one)
    public override int DemThuMuc()
    {
        int count = 1; // Count this directory
        foreach (var luuTru in ds)
        {
            count += luuTru.DemThuMuc(); // Recursive count
        }
        return count;
    }
}

// Disk class to manage the directory tree
public class CDia
{
    protected int n; // Number of storage objects
    protected List<CLuuTru> ds; // Dynamic list of storage objects

    // Constructor
    public CDia()
    {
        ds = new List<CLuuTru>(); // Initialize empty list
    }

    // Input method for disk
    public void Nhap()
    {
        Console.Write("Nhap so luong doi tuong luu tru: ");
        n = int.Parse(Console.ReadLine());
        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap doi tuong luu tru [{i}] (0: Tap tin, 1: Thu muc): ");
            int type = int.Parse(Console.ReadLine());
            CLuuTru temp;
            if (type == 0)
                temp = new CTapTin();
            else
                temp = new CThuMuc();
            temp.Nhap();
            ds.Add(temp);
        }
    }

    // Output method for disk
    public void Xuat()
    {
        Console.WriteLine($"So luong doi tuong luu tru: {n}");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Doi tuong luu tru [{i}]:");
            ds[i].Xuat();
        }
    }

    // Calculate total size of disk
    public float TinhDungLuong()
    {
        float s = 0;
        foreach (var luuTru in ds)
        {
            s += luuTru.TinhDungLuong();
        }
        return s;
    }

    // Count total files
    public int DemTapTin()
    {
        int count = 0;
        foreach (var luuTru in ds)
        {
            count += luuTru.DemTapTin();
        }
        return count;
    }

    // Count total directories
    public int DemThuMuc()
    {
        int count = 0;
        foreach (var luuTru in ds)
        {
            count += luuTru.DemThuMuc();
        }
        return count;
    }
}

// Main program class
public class Program
{
    public static void Main(string[] args)
    {
        CDia dia = new CDia(); // Create disk object (like C++: CDia* dia = new CDia())
        dia.Nhap(); // Input the directory tree
        Console.WriteLine("\nDanh sach doi tuong luu tru:");
        dia.Xuat(); // Output the directory tree
        Console.WriteLine($"\nTong dung luong: {dia.TinhDungLuong()} MB");
        Console.WriteLine($"So luong tap tin: {dia.DemTapTin()}");
        Console.WriteLine($"So luong thu muc: {dia.DemThuMuc()}");
    }
}