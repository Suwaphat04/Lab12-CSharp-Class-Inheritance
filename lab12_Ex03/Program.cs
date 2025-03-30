using System;

class BaseClass1
{
    public BaseClass1()
    {
        Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public BaseClass2()
    {
        Console.WriteLine("This is BaseClass2");
    }
}

class DerivedClass : BaseClass1
{
    public DerivedClass()
    {
        Console.WriteLine("This is DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
    }
}

