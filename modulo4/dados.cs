using System;

public class Program
{
    public static void Main()
    {
        // Roll the dice
        Random dado = new Random();
        int dado1 = dado.Next(1, 7);
        int dado2 = dado.Next(1, 7);
        int dado3 = dado.Next(1, 7);
        int total = dado1 + dado2 + dado3;

        // Display the roll and total
        Console.WriteLine($"Primeiro Dado: {dado1}\nSegundo Dado: {dado2}\nTerceiro Dado: {dado3}\nTotal (Soma dos Três Dados): {total}");

        // Award a bonus for doubles or triples
        if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
        {
            if ((dado1 == dado2) && (dado2 == dado3))
            {
                Console.WriteLine("Você rolou três dados iguais! +6 pontos bônus ao total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("Você rolou dois dados iguais! +2 pontos bônus ao total!");
                total += 2;
            }
        }

        // Display the final result
        Console.WriteLine($"No fim, você pontuou {total} pontos!");

    }
}
