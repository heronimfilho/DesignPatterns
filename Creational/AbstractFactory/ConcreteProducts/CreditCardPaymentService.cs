using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class CreditCardPaymentService : IPaymentService {
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Payment of ${amount} made with Credit Card.");
    }
}
