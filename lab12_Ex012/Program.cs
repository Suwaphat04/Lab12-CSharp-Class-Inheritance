using System;

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}

class DerivedClass : BaseClass
{
    // ใช้ 'new' เพื่อซ่อนฟิลด์ Hello ใน BaseClass
    new public string Hello = "Hello From DerivedClass";

    public void PrintBaseHello()
    {
        // ใช้ 'base' เพื่อเข้าถึงฟิลด์ Hello จาก BaseClass
        string BaseHello = base.Hello;  // เข้าถึงฟิลด์ Hello ของ BaseClass
        System.Console.WriteLine(BaseHello);  // แสดงผลค่าจาก BaseClass
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        dc.PrintBaseHello();  // เรียกใช้งานเมธอด PrintBaseHello
    }
}

