using Infraestructure;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Lilab_2.Extensions;

public static class ApplicationBuilderExtension
{
    public static async void ApplyMigrations(this IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            //Acceder al contenedor de dependecia dentro del alcance creado
            var service = scope.ServiceProvider;
            //Utilizar un servicio de log
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
                //Creo una instancia del contexto la base de datos ApplicationDbContext
                var context = service.GetRequiredService<ApplicationDbContext>();
                //Ejecuto las migraciones
                await context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                //Creo un logger asociado a la clase Program
                var logger = loggerFactory.CreateLogger<Program>();
                //Imprimo el logger
                logger.LogError(ex, "Ocurrio un error en la migracion de la capa dominio a la base de datos");
                throw;
            }

        }
    }
}
