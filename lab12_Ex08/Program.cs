using System;

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}

class DerivedClass : BaseClass
{
    public string Hello = "Hello From DerivedClass";
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        Console.WriteLine(dc.Hello);       // จะพิมพ์ "Hello From DerivedClass"
        Console.WriteLine(((BaseClass)dc).Hello); // จะพิมพ์ "Hello From BaseClass" โดยการใช้ base class
    }
}

