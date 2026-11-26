using System;

public class Program
{
    public static void Main()
    {
        // Gera um número aleatório de dias até a expiração
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        // Exibe uma mensagem de expiração com base nos dias restantes
        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Sua assinatura expirou.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Sua assinatura expira em um dia!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Sua assinatura expira em {daysUntilExpiration} dias.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Sua assinatura expirará em breve. Renove agora!");
        }

        // Exibe uma mensagem de desconto se houver algum desconto aplicável
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renove agora e ganhe um desconto de {discountPercentage}%.");
        }

    }
}
