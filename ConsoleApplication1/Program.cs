using ConsoleApplication1;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddGenerators();
var provider = services.BuildServiceProvider();

do
{
    IOutputGenerator? generator = Console.ReadLine() switch
    {
        "1" => provider.GetRequiredService<ReverseEvenNumberGenerator>(),
        "2" => provider.GetRequiredService<Class1>(),
        "3" => provider.GetRequiredService<OddNumberGenerator>(),
        _ => null
    };

    if (generator is null) break;
    Console.WriteLine(generator.GenerateOutput());
} while (true);
