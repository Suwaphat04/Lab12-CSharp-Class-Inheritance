using System;

class BaseClass
{
    public string Field1 = "Field1 of BaseClass"; 
}

class DerivedClass : BaseClass
{
    // ใช้ 'new' เพื่อซ่อนฟิลด์ Field1 ใน BaseClass
    new public string Field1 = "Field1 of DerivedClass"; 
}

class Program
{
    static void Main()
    {
        DerivedClass DC = new DerivedClass();
        // แสดงฟิลด์ Field1 จาก DerivedClass
        System.Console.WriteLine($"DC.Field1 = {DC.Field1}");

        // การแปลง DC เป็น BaseClass และเข้าถึง Field1 จาก BaseClass
        BaseClass BC = (BaseClass)DC;
        System.Console.WriteLine($"BC.Field1 = {BC.Field1}");
    }
}

