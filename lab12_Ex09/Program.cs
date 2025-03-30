using System;

class BaseClass
{
    public string Hello = "Hello From BaseClass";

    public void Greeting()
    {
        Console.WriteLine("This is method in BaseClass");
        Console.WriteLine(Hello);
    }
}

class DerivedClass : BaseClass
{
    public new string Hello = "Hello From DerivedClass";  // ใช้ new แทนการ override

    public new void Greeting()  // ใช้ new แทนการ override
    {
        Console.WriteLine("This is method in DerivedClass");
        Console.WriteLine(Hello);
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        dc.Greeting();
    }
}

