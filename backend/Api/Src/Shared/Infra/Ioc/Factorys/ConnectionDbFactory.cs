using Api.Src.Config.Environments;
using Api.Src.Shared.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class ConnectionDbFactory 
    {
        public static IServiceCollection RegisterDbConnections(this IServiceCollection connections)
        {
            connections.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(Constants.ConnectionString);
            });

            return connections;
        }
    }
}
