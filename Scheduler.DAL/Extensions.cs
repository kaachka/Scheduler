using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Repositories;

namespace Scheduler.DAL
{
    public static class Extensions
    {
        public static void AddDbServices(this IServiceCollection services, string connection, string migrationsAssemblyName)
        {
            services.AddDbContext<DataBaseContext>(
                op => op.UseSqlServer(connection,
                    op => op.MigrationsAssembly(migrationsAssemblyName)));

            services.AddScoped<DbContext, DataBaseContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}