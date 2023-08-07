using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class SmsNotificationService : INotificationService {
    public void SendNotification()
    {
        Console.WriteLine("Notification sent via SMS.");
    }
}
