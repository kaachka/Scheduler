using Microsoft.Extensions.DependencyInjection;
using Scheduler.BLL.Interfaces;
using Scheduler.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL
{
    public static class Extensions
    {
        public static void AddBLLServices(this IServiceCollection service)
        {
            service.AddScoped<IEventService, EventService>();
            service.AddScoped<IUserService, UserService>();
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
