using System;

public class Program
{
    public static void Main()
    {
         // Declare variables using an explicit type
        string name = "Gabriel Braga Vitareli";

         // Declare a variable using var
        var age = 17;

         // Display the values of your variables
        Console.WriteLine($"Seu nome é {name} e sua idade é {age}");

         // Reassign a variable to a new value
        age = 18;
        Console.WriteLine($"Idade alterada para {age}");
    }
}
