namespace RunProgram.Interfaces;

public interface INotificationService
{
    void SendNotification(string recipient,string message);
}