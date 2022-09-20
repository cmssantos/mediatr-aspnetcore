using MediatR;
using MediatR.AspnetCore.Application;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRAspnetCore.Infra.IoC;

public static class ServicesExtensions
{
    public static void RegisterMediatRDependencies(this IServiceCollection services)
    {
        services.AddMediatR(typeof(PingCommandHandler).Assembly);
    }
}