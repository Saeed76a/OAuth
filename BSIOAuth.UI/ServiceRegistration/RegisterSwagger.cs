using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
namespace BSIOAuth.UI.ServiceRegistration;

public static class RegisterSwagger
{
    public static IServiceCollection AddCustomeSwagger(this IServiceCollection service)
    {
        var authUrl = AppInfos.IDENTITY_API_URL_SECTION;
        var AppName = AppInfos.AppName;

        service.AddSwaggerGen(c =>
        {

            c.SwaggerDoc("v1", new OpenApiInfo { Title = AppName, Version = "v1" });
            c.EnableAnnotations();
        });
        return service;
    }
}