using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ecommerce.Application.Shared;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection Service)
    {
        //Configure AutoMapper
        Service.AddAutoMapper(typeof(CategoryMappingProfile));
        Service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}
