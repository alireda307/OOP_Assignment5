namespace RunProgram;
using RunProgram.Classes;
using RunProgram.Interfaces;

class Program
{
    static void Main(string[] args) 
    {
        /*
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        circle.DisplayShapeInfo();
        rectangle.DisplayShapeInfo();
        */
        
        /*
        IAuthenticationService authService = new BasicAuthenticationService();

        Console.Write("Enter username: ");
        string? username = Console.ReadLine();

        Console.Write("Enter password: ");
        string? password = Console.ReadLine();

        bool isAuthenticated = authService.AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            Console.WriteLine("User authenticated successfully.");

            Console.Write("Enter role to check authorization: ");
            string? role = Console.ReadLine();

            bool isAuthorized = authService.AuthorizeUser(username, role);

            if (isAuthorized)
                Console.WriteLine("User is authorized for this role.");
            else
                Console.WriteLine("User is NOT authorized for this role.");
        }
        else
        {
            Console.WriteLine("Authentication failed. Invalid username or password.");
        }
        */
        
        /*
        INotificationService emailService = new EmailNotificationService();
        INotificationService smsService = new SmsNotificationService();
        INotificationService pushService = new PushNotificationService();

        emailService.SendNotification("ali@example.com", "Welcome to our platform!");
        smsService.SendNotification("+20123456789", "Your OTP is 123456");
        pushService.SendNotification("Ali’s Device", "You have a new message!");
        */
        
        /*
        var orderPayPal = new OrderService(new PayPalPayment());
        orderPayPal.PlaceOrder(100);

        var orderStripe = new OrderService(new StripePayment());
        orderStripe.PlaceOrder(200);

        var orderCash = new OrderService(new CashPayment());
        orderCash.PlaceOrder(50);
        */
    }
}
