using AbstractFactory.Abstract.Interfaces;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.Concrete;

public class PayPalServicesFactory : IBankServicesFactory
{
    public IPaymentService CreatePaymentService() => new PayPalPaymentService();
    public INotificationService CreateNotificationService() => new SmsNotificationService();
    public ITransactionLog CreateTransactionLog() => new DatabaseTransactionLog();
    public IFraudDetectionService CreateFraudDetectionService() => new PayPalFraudDetectionService();
}
