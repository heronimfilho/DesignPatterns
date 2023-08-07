using AbstractFactory.Abstract.Interfaces;
using AbstractFactory.Concrete;
using BuildingBlocks;

namespace AbstractFactory;

public class AbstractFactoryHandler : Handler
{
    public override void Handle()
    {
        IBankServicesFactory creditCardFactory = new CreditCardServicesFactory();
        IBankServicesFactory payPalFactory = new PayPalServicesFactory();

        ShowcaseFactory(creditCardFactory);
        ShowcaseFactory(payPalFactory);
    }

    private void ShowcaseFactory(IBankServicesFactory factory)
    {
        IPaymentService paymentService = factory.CreatePaymentService();
        INotificationService notificationService = factory.CreateNotificationService();
        ITransactionLog transactionLog = factory.CreateTransactionLog();
        IFraudDetectionService fraudDetectionService = factory.CreateFraudDetectionService();

        paymentService.MakePayment(100);
        notificationService.SendNotification();
        transactionLog.LogTransaction(100, "Payment");
        fraudDetectionService.DetectFraud();

        Console.WriteLine("-----------------------------");
    }
}
