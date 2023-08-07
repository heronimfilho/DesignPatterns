using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class DatabaseTransactionLog : ITransactionLog {
    public void LogTransaction(double amount, string description)
    {
        Console.WriteLine($"Transaction logged to database: ${amount}, {description}.");
    }
}
