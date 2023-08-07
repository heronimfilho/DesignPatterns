using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;
    public class PayPalFraudDetectionService : IFraudDetectionService
    {
        public void DetectFraud()
        {
            Console.WriteLine("Fraud detection for PayPal payment.");
        }
    }
