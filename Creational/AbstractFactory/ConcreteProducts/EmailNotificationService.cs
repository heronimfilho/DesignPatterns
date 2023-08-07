using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class EmailNotificationService : INotificationService {
    public void SendNotification()
    {
        Console.WriteLine("Notification sent via Email.");
    }
}
