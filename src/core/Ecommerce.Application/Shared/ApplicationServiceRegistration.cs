
using System.Reflection;
using FluentValidation;
namespace Ecommerce.Application.Shared
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            //Configure AutoMapper && MediatR && Fluient Validation
            services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
