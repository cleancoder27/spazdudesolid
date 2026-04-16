using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication1;

/// <summary>
/// The registration details of this example are not significant to the solution
/// </summary>
public static class AppInstaller
{
    public static IServiceCollection AddGenerators(this IServiceCollection services)
    {
        services.AddTransient<IRange>(_ => new Range(0, 100));

        services.AddTransient<ReverseEvenNumberGenerator>();

        services.AddTransient<Class1>(_ =>
        {
            var instance = new Class1();
            instance.SetRange(0, 100);
            return instance;
        });

        services.AddTransient<OddNumberGenerator>(provider =>
            new OddNumberGenerator { Range = provider.GetRequiredService<IRange>() });

        return services;
    }
}
