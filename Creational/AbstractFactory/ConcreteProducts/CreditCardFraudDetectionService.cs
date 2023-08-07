using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class CreditCardFraudDetectionService : IFraudDetectionService {
    public void DetectFraud()
    {
        Console.WriteLine("Fraud detection for Credit Card payment.");
    }
}
