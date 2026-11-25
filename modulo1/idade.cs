using System;

public class Program
{
    public static void Main()
    {
        // Ask for the user's name
        Console.WriteLine("Qual seu nome? ");
        string Nome = Console.ReadLine();

        // Ask for the user's age
        Console.WriteLine("Qual sua idade? ");
        string Idade = Console.ReadLine();

        // Display a personalized greeting
        Console.WriteLine($"Bem-vindo {Nome}! Você tem {Idade} anos.");

    }
}
