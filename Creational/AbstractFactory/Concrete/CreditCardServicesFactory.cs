using AbstractFactory.Abstract.Interfaces;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.Concrete;

public class CreditCardServicesFactory : IBankServicesFactory
{
    public IPaymentService CreatePaymentService() => new CreditCardPaymentService();
    public INotificationService CreateNotificationService() => new EmailNotificationService();
    public ITransactionLog CreateTransactionLog() => new FileTransactionLog();
    public IFraudDetectionService CreateFraudDetectionService() => new CreditCardFraudDetectionService();
}
