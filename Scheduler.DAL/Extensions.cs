using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scheduler.DAL.DataBase;

namespace Scheduler.DAL
{
    public static class Extensions
    {
        public static void AddDbServices(this IServiceCollection services, string connection, string migrationsAssemblyName)
        {
            services.AddDbContext<DataBaseContext>(
                op => op.UseSqlServer(connection,
                    op => op.MigrationsAssembly(migrationsAssemblyName)));
        }
    }
}