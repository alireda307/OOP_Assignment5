namespace RunProgram.Classes;
using Interfaces;

public class OrderService
{
    private readonly IPayment _payment;

    public OrderService(IPayment payment)
    {
        _payment = payment;
    }

    public void PlaceOrder(decimal amount)
    {
        Console.WriteLine("Order placed.");
        _payment.Pay(amount);
    }
}    