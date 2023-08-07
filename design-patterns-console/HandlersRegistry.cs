using BuildingBlocks;
using AbstractFactory;

namespace DesignPatternsConsole;

internal class HandlersRegistry
{
    private static HandlersRegistry? _instance;
    private readonly List<Handler> handlers;

    public static HandlersRegistry Instance => _instance ??= new HandlersRegistry();
    public List<Handler> Load() => handlers;

    private HandlersRegistry()
    {
        handlers = new List<Handler>() {
            new AbstractFactoryHandler()
        };
    }
}
