namespace RunProgram.Classes;
using RunProgram.Interfaces;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Sending SMS to {recipient}: {message}");
    }
}