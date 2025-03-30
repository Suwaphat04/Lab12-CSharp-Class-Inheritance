using System;

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}

class DerivedClass : BaseClass
{
    // ใช้ new เพื่อซ่อนฟิลด์ Hello ใน BaseClass
    new public string Hello = "Hello From DerivedClass";
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        // แสดงผลของฟิลด์ Hello จาก DerivedClass
        Console.WriteLine(dc.Hello);
    }
}
