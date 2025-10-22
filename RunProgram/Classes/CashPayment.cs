using RunProgram.Interfaces;

namespace RunProgram.Classes;

public class CashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} using cash.");
    }
}