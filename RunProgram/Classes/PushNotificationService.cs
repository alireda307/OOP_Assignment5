namespace RunProgram.Classes;
using RunProgram.Interfaces;

public class PushNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
    }
}