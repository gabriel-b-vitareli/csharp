using System;

public class Program
{
    public static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Olá! Seja bem vindo.");

         // Ask for the user's name
        Console.WriteLine("Qual seu nome? ");
        string Nome = Console.ReadLine();

         // Display a personalized greeting
        Console.WriteLine($"Bem-vindo {Nome}!");
    }
}
