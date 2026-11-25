using System;

public class Program
{
    public static void Main()
    {
        // Collect the bill amount and tip percentage
        Console.WriteLine("Digite o valor total da conta:");
        string bill = Console.ReadLine()!;
        decimal billDecimal = decimal.Parse(bill);

        Console.WriteLine("Digite o valor da porcentagem de gorjeta:");
        string tip = Console.ReadLine()!;
        decimal tipDecimal = Convert.ToDecimal(tip);

        // Display the entered values
        Console.WriteLine($"A conta ficou em R${billDecimal} e você pagará mais {tipDecimal}% em gorjeta.");

        // Calculate the tip and total
        decimal tipValue = (billDecimal * tipDecimal) / 100;
        decimal total = billDecimal + tipValue;

        // Display the results
        Console.WriteLine($"Isso significa que você pagará R${tipValue} em gorjeta e o valor final da conta ficará em R${total}");

    }
}
