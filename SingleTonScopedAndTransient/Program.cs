using Microsoft.Extensions.DependencyInjection;
using SingleTonScopedAndTransient;

Console.WriteLine("SingleTon, Scoped And Transient Trail Program");

Console.WriteLine("Hello, World!");

var collection = new ServiceCollection();

//Same as request end
collection.AddScoped<ScopedClass>();

//Every time new
collection.AddTransient<TransientClass>();

var builder = collection.BuildServiceProvider();

Console.Clear();

Parallel.For(1, 10, i =>
{
    Console.WriteLine($"Spoed Instance ID ={ builder.GetService<ScopedClass>().GetHashCode().ToString()}");
    Console.WriteLine($"Trancent Instance ID ={ builder.GetService<TransientClass>().GetHashCode().ToString()}");
});

Console.ReadKey();