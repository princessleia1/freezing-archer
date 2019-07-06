using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(nameof(System.String));
        int j = 5;
        Console.WriteLine(nameof(j));
        List<string> names = new List<string>();
        Console.WriteLine(nameof(names));
    }
}