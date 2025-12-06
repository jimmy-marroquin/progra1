using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using webappacademica.Models;

// Cambia 'WebApplication.CreateBuilder' por 'var builder = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });'
// Sin embargo, en .NET 6+ y plantillas modernas, 'WebApplication.CreateBuilder' está disponible si tienes la referencia correcta.
// Asegúrate de que tu proyecto esté usando .NET 6 o superior y que el paquete 'Microsoft.AspNetCore.App' esté referenciado.

// Si tu proyecto es .NET 5 o anterior, usa el patrón Startup y HostBuilder.
// Si es .NET 6+, asegúrate de que el SDK y los paquetes sean correctos.

// Si tienes .NET 6+, pero el error persiste, agrega la referencia al paquete NuGet 'Microsoft.AspNetCore.App' y asegúrate de que el SDK sea 'net6.0' o superior en tu archivo .csproj:
// <TargetFramework>net6.0</TargetFramework>

// No se requiere cambio de código si el SDK y los paquetes son correctos.
// Si usas .NET 5 o anterior, cambia a este patrón:

/*
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseStaticFiles();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
*/

// Si tu proyecto es .NET 6+, revisa el archivo .csproj y asegúrate de que el SDK sea correcto.
