using GB_WebAppCource.DAL.Repository.Database;
using Microsoft.Extensions.DependencyInjection;

namespace GB_WebAppCource
{
    public static class Extensions
    {
        public static IServiceCollection AddSqlRepository(this IServiceCollection container)
        {
            container.AddSingleton<Context>();

            return container;
        }
    }
}
