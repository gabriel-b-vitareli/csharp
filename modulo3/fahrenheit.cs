using System;

public class Program
{
    public static void Main()
    {
        // Store a Fahrenheit temperature
        decimal fahrenheit = 94;

        // Convert it to Celsius
        decimal celsius = (fahrenheit - 32) * 5 / 9;

        // Display the result
        Console.WriteLine($"{fahrenheit}°F é igual a {celsius}°C");
    }
}
