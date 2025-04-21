global using Dapper;
global using Microsoft.Data.SqlClient;
global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ItProject.UI.Client;
using ItProject.UI.Infrastructure.Repositories;
using ItProject.UI.Domain.Interface;
using ItProject.UI.FormDialog;

namespace ItProject.UI;

internal static class Program
{
    private static IServiceProvider? _serviceProvider;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<SendToBack>();
        services.AddDbContext<DataBaseContext>(x =>
         x.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ИтЗаказы;Integrated Security=True;TrustServerCertificate=True"));

        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IWorkerRepository, WorkerRepository>();


        _serviceProvider = services.BuildServiceProvider();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var clientRepository = _serviceProvider.GetRequiredService<IClientRepository>();
        var workerRepository = _serviceProvider.GetRequiredService<IWorkerRepository>();
        var sendToBack = _serviceProvider.GetRequiredService<SendToBack>();
        //Application.Run(new FormMain(sendToBack, clientRepository, workerRepository));
        Application.Run(new FormAuth(sendToBack, clientRepository, workerRepository));
    }
}
