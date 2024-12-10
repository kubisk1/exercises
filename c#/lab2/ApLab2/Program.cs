using System;
using TestLib1;

class Program
{
    static void Main(string[] args)
    {
        TestClass c = new TestClass();
        Console.WriteLine("Wersja: {0}", c.Version);
        Console.ReadKey();
    }
}
