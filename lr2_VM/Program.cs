using System;
using TestNetStandard;

class Program
{
    static void Main()
    {
        string email = "example@test.com";

        Validation.Validate(email,
            Success: () => Console.WriteLine("Email +!"),
            Fail: () => Console.WriteLine("Email -!"));

        Console.WriteLine("\nPress...");
        Console.ReadKey();
    }
}
