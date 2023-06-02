// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SortingPractice.Algorithims;
using SortingPractice.IAlgorithims;
using SortingPractice.ISort;
using SortingPractice.Sort;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        BuildConfig(builder);
        var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
        {
            //services.AddTransient<IConfigurationProvider, ConfigurationProvider>();
            services.AddTransient<ISortingArgument,SortingArgument>();
            services.AddTransient(typeof(Sorting<>));
            services.AddTransient<IBubbleSort,BubbleSort>();
            //services.AddScoped<IBubbleSort,BubbleSort>();
        }).UseSerilog().Build();
        var srvc = ActivatorUtilities.CreateInstance<SortingArgument>(host.Services);
        srvc.Inputs();
    }
    public static void BuildConfig(IConfigurationBuilder builder)
    {
        builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsetting.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")??"Production"}.json").AddEnvironmentVariables();

    }
}