namespace AbstractFactory.Abstract.Interfaces;

public interface IBankServicesFactory
{
    IPaymentService CreatePaymentService();
    INotificationService CreateNotificationService();
    ITransactionLog CreateTransactionLog();
    IFraudDetectionService CreateFraudDetectionService();
}
