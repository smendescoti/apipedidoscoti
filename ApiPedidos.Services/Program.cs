using ApiPedidos.Application.Interfaces;
using ApiPedidos.Application.Services;
using ApiPedidos.Infra.EventBus.Producers;
using ApiPedidos.Infra.EventBus.Settings;
using ApiPedidos.Services.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

SwaggerConfiguration.AddSwagger(builder);
EntityFrameworkConfiguration.AddEntityFramework(builder);
DependencyInjectionConfiguration.AddDependencyInjection(builder);
CorsConfiguration.AddCors(builder);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

CorsConfiguration.UseCors(app);

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
