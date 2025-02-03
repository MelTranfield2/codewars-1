using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        typeof(TestClass).GetProperties().Where(x => x.Name == "MYNAME").FirstOrDefault(); 
    }
}

public class TestClass {
    public string MyProperty { get; set; }
    public string MyProperty2 { get; set; }
}