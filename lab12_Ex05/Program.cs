using System;

interface IBaseInterface1
{
    void Method1();
}

interface IBaseInterface2
{
    void Method2();
}

class BaseClass1 : IBaseInterface1
{
    public BaseClass1()
    {
        Console.WriteLine("This is BaseClass1");
    }

    public void Method1()
    {
        Console.WriteLine("Method1 from BaseClass1");
    }
}

class BaseClass2 : IBaseInterface2
{
    public BaseClass2()
    {
        Console.WriteLine("This is BaseClass2");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 from BaseClass2");
    }
}

class DerivedClass : BaseClass1, IBaseInterface2
{
    public DerivedClass() : base()
    {
        Console.WriteLine("This is DerivedClass");
    }

    // Override method from IBaseInterface2
    public void Method2()
    {
        Console.WriteLine("Method2 from DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        dc.Method1(); // Output: Method1 from BaseClass1
        dc.Method2(); // Output: Method2 from DerivedClass
    }
}
