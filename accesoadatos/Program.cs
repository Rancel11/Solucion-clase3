
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using NORTHWIND.APLICACTION.Abstrations;
using NORTHWIND.INFRACTUTURE;
using Serilog;


namespace accesoadatos
{
    internal static class Program
    {

        
        public static IConfiguration configuration { get; private set; }




        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            var serviceColletion = new ServiceCollection();



            try
            {

                configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
                
                serviceColletion.AddSingleton < IConfiguration>(configuration);




                // infraestructura
                serviceColletion.AddScoped<Isuppliersreporitory, suppliersrReporitory>();
                
                serviceColletion.AddScoped<ICategoryRepository, Categoryrepository>();
                
                // presentacion 
              

                serviceColletion.AddTransient<MenuPrincipal>();

                var serviceprovaider = serviceColletion.BuildServiceProvider();


                Log.Information("La aplicación está iniciando.");
                

                ApplicationConfiguration.Initialize();
                Application.Run(serviceprovaider.GetRequiredService<MenuPrincipal>());
            }

            catch (Exception ex)
            {
                Log.Fatal(ex, "Error fatal en la aplicación.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }


    }
}







