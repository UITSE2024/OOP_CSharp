using System;

// Lớp cơ sở A với hai phương thức Sketchy:
// - Sketchy(): không tham số, gọi Sketchy(int) với giá trị -1.
// - Sketchy(int num): phương thức ảo, nhận một số nguyên và in ra giá trị đó.
public class A
{
    public void Sketchy()
    {
        Console.WriteLine("\n A's Sketchy()");
        Sketchy(-1); // Gọi phương thức Sketchy(int) với giá trị -1
    }

    public virtual void Sketchy(int num)
    {
        Console.WriteLine("\n A's Sketchy(" + num + ")");
    }
}

// Lớp B kế thừa từ A, che dấu (new) phương thức Sketchy() và ghi đè (override) Sketchy(int)
// - Sketchy(): che dấu phương thức của A, gọi Sketchy(int) với giá trị -2.
// - Sketchy(int num): ghi đè phương thức của A, in ra giá trị num.
public class B : A
{
    public new void Sketchy()
    {
        Console.WriteLine("\n B's Sketchy()");
        Sketchy(-2); // Gọi phương thức Sketchy(int) với giá trị -2
    }

    public override void Sketchy(int num)
    {
        Console.WriteLine("\n B's Sketchy(" + num + ")");
    }
}

// Lớp C kế thừa từ B, chỉ ghi đè phương thức Sketchy(int)
// - Sketchy(int num): ghi đè phương thức của B, in ra giá trị num.
public class C : B
{
    public override void Sketchy(int num)
    {
        Console.WriteLine("\n C's Sketchy(" + num + ")");
    }
}

public class Program
{
    // Phương thức Curious nhận một đối tượng kiểu A:
    // - Gọi Sketchy() (phụ thuộc kiểu tham chiếu)
    // - Ép kiểu sang C và gọi Sketchy(123)
    public static void Curious(A wacky)
    {
        wacky.Sketchy(); // Gọi Sketchy() theo kiểu tham chiếu
        ((C)wacky).Sketchy(123); // Ép kiểu sang C và gọi Sketchy(int)
    }

    public static void Main()
    {
        // Tạo đối tượng inky kiểu A, thực thể B
        A inky = new B();
        inky.Sketchy();      // Gọi Sketchy() của A (do kiểu tham chiếu là A), sẽ gọi tiếp Sketchy(int) của B do ghi đè
        inky.Sketchy(23);    // Gọi Sketchy(int) của B (do ghi đè)

        //Curious(inky);    // Không gọi vì inky không phải là C, sẽ lỗi khi ép kiểu

        // Tạo đối tượng pinky kiểu B, thực thể C
        B pinky = new C();
        pinky.Sketchy();     // Gọi Sketchy() của B (do che dấu), sẽ gọi tiếp Sketchy(int) của C do ghi đè
        pinky.Sketchy(46);   // Gọi Sketchy(int) của C (do ghi đè)
        Curious(pinky);      // Gọi Sketchy() của B, sau đó ép kiểu sang C và gọi Sketchy(int) của C
    }
}
