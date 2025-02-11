using Hivelogs.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Hivelogs.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddHivelogsServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthCheck(configuration);
            services.AddDatabaseConnection(configuration);
            return services;
        }

        private static IServiceCollection AddDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("[ERROR] Database connection string is missing. Please set 'ConnectionStrings:DefaultConnection' in environment variables.");

            services.AddDbContext<HivelogsDbContext>(options => options
                .UseLazyLoadingProxies()
                .UseNpgsql(connectionString));

            return services;
        }

        private static IServiceCollection AddHealthCheck(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("[ERROR] Database connection string is missing. Please set 'ConnectionStrings:DefaultConnection' in environment variables.");

            services.AddHealthChecks()
                .AddCheck("API Running", () => HealthCheckResult.Healthy("✅ API is up and running"))
                .AddNpgSql(
                    connectionString,
                    name: "PostgreSQL",
                    failureStatus: HealthStatus.Unhealthy
                );

            return services;
        }
    }
}
