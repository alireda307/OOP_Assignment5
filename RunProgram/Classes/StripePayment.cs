using RunProgram.Interfaces;

namespace RunProgram.Classes;

public class StripePayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Stripe.");
    }
}