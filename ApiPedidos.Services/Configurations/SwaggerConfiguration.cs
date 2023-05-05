using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ApiPedidos.Services.Configurations
{
    public class SwaggerConfiguration
    {
        public static void AddSwagger(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "API para controle de pedidos - COTI Informática",
                        Version = "v1",
                        Contact = new OpenApiContact
                        {
                            Name = "COTI Informática",
                            Email = "contato@cotiinformatica.com.br",
                            Url = new Uri("http://www.cotiinformatica.com.br")
                        }
                    });
            });
        }
    }
}
