namespace AbstractFactory.Abstract.Interfaces;

public interface ITransactionLog
{
    void LogTransaction(double amount, string description);
}