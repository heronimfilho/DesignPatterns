using AbstractFactory.Abstract.Interfaces;

namespace AbstractFactory.ConcreteProducts;

public class FileTransactionLog : ITransactionLog {
    public void LogTransaction(double amount, string description)
    {
        Console.WriteLine($"Transaction logged to file: ${amount}, {description}.");
    }
}
