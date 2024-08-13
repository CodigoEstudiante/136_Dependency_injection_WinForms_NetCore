using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;

namespace WinFormsDI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var formService =   host.Services.GetRequiredService<Form1>();

            //Application.Run(new Form1());
            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => {
                config.AddJsonFile("appsettings.json",optional:false,reloadOnChange:true);
            })
            .ConfigureServices((context,services) => {
                
                services.AddTransient<Form1>();
                services.AddTransient<Form2>();
                services.AddTransient<IMyService, MyService>();
            });



    }
}