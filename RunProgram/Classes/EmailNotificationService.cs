using RunProgram.Interfaces;

namespace RunProgram.Classes;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Sending Email to {recipient}: {message}");
    }
}