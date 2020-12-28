using Microsoft.Extensions.DependencyInjection;
using Snacks.Entity.Core.Database;
using Snacks.Entity.SqlServer;
using System;
using System.Data.SqlClient;

namespace Snacks.Entity.Sqlite.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlServerService(this IServiceCollection services, Action<SqlServerOptions> setupAction)
        {
            if (setupAction != null)
            {
                services.Configure(setupAction);    
            }

            return services.AddSingleton<IDbService<SqlConnection>, SqlServerService>();
        }
    }
}
