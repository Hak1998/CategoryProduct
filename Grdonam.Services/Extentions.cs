using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
namespace Grdonam.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductServie, ProductService>();
            services.AddTransient<ICategoryServie, CategoryService>();
            return services;
        }
    }
}
