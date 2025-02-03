using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //gets type info
        typeof(TestClass).GetProperties().ToList().ForEach(x => Console.WriteLine(x.Name));
    }
}

public class TestClass {
    public string MyProperty { get; set; }
    public string MyProperty2 { get; set; }
}