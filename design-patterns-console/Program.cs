using BuildingBlocks;

namespace DesignPatternsConsole;

public class Program
{
    private static void Main(string[] args)
    {
        List<Handler> handlers = HandlersRegistry.Instance.Load();
        foreach (Handler handler in handlers)
        {
            handler.Handle();
            Console.ReadKey();
        }
    }
}