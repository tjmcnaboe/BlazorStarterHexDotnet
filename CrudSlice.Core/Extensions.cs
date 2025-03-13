using CrudSlice.Entity;
using CrudSlice.Model;
using Foundation.DataObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSlice.Core
{
    public static class ComponentExtensions
    {
        public static IServiceCollection AddTemplateClassServices(this IServiceCollection services, string connectionString)
        {

            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5cdHZURGleWEB2V0Y=");
            //services.AddSyncfusionBlazor();
            services.AddDbContextFactory<TemplateDbContext>(options =>
                options.UseSqlServer(connectionString), ServiceLifetime.Scoped);
            services.AddScoped<ITemplateClassDtoEntityService, MappedTemplateClassService<TemplateDbContext>>();
            //builder.Services.AddScoped<IEmployeeDetailVmService, MappedEmployeeService<ApplicationDbContext>>();
            services.AddScoped<IEntityObjectMapper<TemplateClass, TemplateClassDTO>, TemplateClassMapper>();
            services.AddControllers();

            //services.AddDbContextFactory<TemplateDbContext>(options =>
            //    options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

            //services.AddScoped<IEntityObjectMapper<TemplateClass, TemplateClassDTO>, TemplateClassMapper>();
            //services.AddScoped<ITemplateClassDtoEntityService, MappedTemplateClassService<TemplateDbContext>>();
            return services;
        }
    }
}
