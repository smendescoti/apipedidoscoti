using ApiPedidos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ApiPedidos.Services.Configurations
{
    public class EntityFrameworkConfiguration
    {
        public static void AddEntityFramework(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("BdApiPedidos");

            builder.Services.AddDbContext<DataContext>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
