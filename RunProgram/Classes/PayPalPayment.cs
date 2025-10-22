using RunProgram.Interfaces;
namespace RunProgram.Classes;

public class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPaL.");
    }
}