using System;


public class A
{
    public void Sketchy()
    {
        Console.WriteLine("\n A's Sketchy()");
        Sketchy(-1);
    }
    public void Sketchy(int num)
    {
        Console.WriteLine("\n A's Sketchy(" + num + ")");
    }
}

public class B : A
{
    public new void Sketchy()
    {
        Console.WriteLine("\n B's Sketchy()");
        Sketchy(-2);
    }
    public new void Sketchy(int num)
    {
        Console.WriteLine("\n B's Sketchy(" + num + ")");
    }
}

public class C : B
{
    public new void Sketchy(int num)
    {
        Console.WriteLine("\n C's Sketchy(" + num + ")");
    }
}

public class Program
{
    public static void Curious(A wacky)
    {
        wacky.Sketchy();
        // In C#, casting 'wacky' to 'C' will throw an InvalidCastException
        // if the runtime type of 'wacky' is not 'C' or a type derived from 'C'.
        // This directly reflects the potential for runtime errors or undefined behavior
        // in C++ for invalid downcasts.
        ((C)wacky).Sketchy(123);
    }

    public static void Main()
    {
        A inky = new B();
        inky.Sketchy();
        inky.Sketchy(23);
        //Curious(inky); // This call will likely result in an InvalidCastException at runtime.

        B pinky = new C();
        pinky.Sketchy();
        pinky.Sketchy(46);
        Curious(pinky);
    }
}