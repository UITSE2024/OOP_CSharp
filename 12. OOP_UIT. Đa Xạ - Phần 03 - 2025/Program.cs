using System;

public class A
{
    public virtual void Sketchy()
    {
        Console.WriteLine("A's Sketchy()");
        Sketchy(-1);
    }

    public virtual void Sketchy(int num)
    {
        Console.WriteLine($"A's Sketchy({num})");
    }
}

public class B : A
{
    public override void Sketchy()
    {
        Console.WriteLine("B's Sketchy()");
        Sketchy(-2);
    }

    public override void Sketchy(int num)
    {
        Console.WriteLine($"B's Sketchy({num})");
    }
}

public class C : B
{
    public override void Sketchy(int num)
    {
        Console.WriteLine($"C's Sketchy({num})");
    }
}

public class PolymorphismExample
{
    public static void Curious(A wacky)
    {
        wacky.Sketchy();
        C c = wacky as C;
        if (c != null)
        {
            c.Sketchy(123); // Mimics C++'s ((C*)wacky)->Sketchy(123)
        }
        else
        {
            throw new InvalidCastException("Cannot cast to C");
        }
    }

    public static void Main(string[] args)
    {
        A inky = new B();
        inky.Sketchy();         // Output: B's Sketchy(), B's Sketchy(-2)
        inky.Sketchy(23);       // Output: B's Sketchy(23)
        try
        {
            Curious(inky);      // Output: B's Sketchy(), B's Sketchy(-2), throws InvalidCastException
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine(e.Message);
        }

        B pinky = new C();
        pinky.Sketchy();        // Output: B's Sketchy(), C's Sketchy(-2)
        pinky.Sketchy(46);      // Output: C's Sketchy(46)
        Curious(pinky);         // Output: B's Sketchy(), C's Sketchy(-2), C's Sketchy(123)
    }
}