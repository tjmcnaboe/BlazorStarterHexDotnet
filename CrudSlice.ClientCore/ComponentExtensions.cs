using CrudSlice.ClientCore;
using CrudSlice.Model;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ComponentExtensions
    {
        public static IServiceCollection AddTemplateClassComponnent(this IServiceCollection services, string endPoint)
        {
            services.AddRefitClient<ITemplateClassDtoHttpService>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(endPoint));
            services.AddScoped<ITemplateClassDtoEntityService, TemplateClassDtoHttpApiService>();
            return services;
        }
    }
}