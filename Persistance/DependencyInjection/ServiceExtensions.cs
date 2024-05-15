using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Contexts;
using Persistance.Repositories;

namespace Persistance.DependencyInjection;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Docker");
        services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));
        services.AddScoped<IMoneyMovementRepository, MoneyMovementRepository>();
    }
}
