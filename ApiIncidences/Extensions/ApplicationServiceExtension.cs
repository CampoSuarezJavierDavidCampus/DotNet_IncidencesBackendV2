using Application.UnitOfWork;
using Domain.Interfaces;

namespace ApiIncidences.Extensions;

static public class ApplicationServiceExtension{
    public static void ConfigureCors(this IServiceCollection services)=>services.AddCors(options=>{
        options.AddPolicy("CorsPolicy",builder=>{
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
    });

    public static void AddApplicationServices(this IServiceCollection services){
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}