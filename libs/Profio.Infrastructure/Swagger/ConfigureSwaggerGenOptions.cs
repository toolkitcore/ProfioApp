using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Profio.Infrastructure.Swagger;

public class ConfigureSwaggerGenOptions : IConfigureOptions<SwaggerGenOptions>
{
  private readonly IApiVersionDescriptionProvider _provider;

  public ConfigureSwaggerGenOptions(IApiVersionDescriptionProvider provider)
    => _provider = provider;

  public void Configure(SwaggerGenOptions options)
  {
    foreach (var description in _provider.ApiVersionDescriptions)
    {
      options.SwaggerDoc(description.GroupName,
        new()
        {
          Title = "Profio API",
          Version = description.ApiVersion.ToString(),
          Description =
            "Profio - the symbol of professionalism in transportation management. Whether you need a solution for managing a fleet of vehicles or ships, Profio provides a powerful tool, optimizing and simplifying the process, ensuring every movement is quick, safe, and efficient. The system is designed to be flexible and scalable, allowing you to manage your fleet of any size, from a few vehicles to thousands of ships. Profio is a product of CJ Logistics, a global leader in transportation and logistics services.",

          Contact = new()
          {
            Name = "HutechCJ",
            Url = new("https://github.com/HutechCJ")
          },

          License = new()
          {
            Name = "MIT",
            Url = new("https://opensource.org/licenses/MIT")
          },

          TermsOfService = new("https://www.cjlogistics.com/en/agreement/privacy-policy")
        });
    }

    options.AddSecurityDefinition("Bearer", new()
      {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme
      });

      options.AddSecurityRequirement(new()
      {
        {
          new()
          {
            Name = JwtBearerDefaults.AuthenticationScheme,
            In = ParameterLocation.Header,
            Reference = new()
            {
              Id = JwtBearerDefaults.AuthenticationScheme,
              Type = ReferenceType.SecurityScheme
            }
          },
          new List<string>()
        }
      });

      options.ResolveConflictingActions(apiDescription => apiDescription.First());
      options.EnableAnnotations();
  }
}
