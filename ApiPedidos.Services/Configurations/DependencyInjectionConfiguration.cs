using ApiPedidos.Application.Interfaces;
using ApiPedidos.Application.Services;
using ApiPedidos.Domain.Interfaces.Repositories;
using ApiPedidos.Domain.Interfaces.Services;
using ApiPedidos.Domain.Services;
using ApiPedidos.Infra.Data.Contexts;
using ApiPedidos.Infra.Data.Repositories;
using ApiPedidos.Infra.EventBus.Producers;
using ApiPedidos.Infra.EventBus.Settings;

namespace ApiPedidos.Services.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(WebApplicationBuilder builder)
        {
            builder.Services.Configure<MessageBrokerSettings>
                (builder.Configuration.GetSection("MessageBrokerSettings"));

            builder.Services.AddTransient<IPedidoAppService, PedidoAppService>();
            builder.Services.AddTransient<IPedidoDomainService, PedidoDomainService>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IPedidoProducer, PedidoProducer>();
            builder.Services.AddTransient<DataContext>();
        }
    }
}
