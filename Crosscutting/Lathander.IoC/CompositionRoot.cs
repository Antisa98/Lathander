using Lathander.Application.Consumers;
using Lathander.Application.Services;
using Lathander.Configuration.Options;
using Lathander.Domain.Interfaces;
using Lathander.Infrastructure.Ingestion;
using Lathander.Infrastructure.Notifications;
using Lathander.Infrastructure.Persistence;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lathander.IoC;

public static class CompositionRoot
{
    public static IServiceCollection AddLathander(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptionsAndConfiguration(configuration);
        services.AddDomainServices();
        services.AddMassTransitBus();

        return services;
    }

    private static IServiceCollection AddOptionsAndConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddOptions<IngestionOptions>()
            .Bind(configuration.GetSection(IngestionOptions.SectionName))
            .ValidateOnStart();

        services
            .AddOptions<PartnerBOptions>()
            .Bind(configuration.GetSection(PartnerBOptions.SectionName))
            .ValidateOnStart();

        return services;
    }

    private static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IIbtMessageSource, FileSystemIbtMessageSource>();
        services.AddScoped<IIbtEventRepository, InMemoryIbtEventRepository>();
        services.AddScoped<IEmailSender, LoggingEmailSender>();
        services.AddScoped<IPartnerBFileNotifier, LocalDiskPartnerBFileNotifier>();

        services.AddScoped<IMessagingProcessService, MessagingProcessService>();

        return services;
    }

    private static IServiceCollection AddMassTransitBus(this IServiceCollection services)
    {
        services.AddMassTransit(bus =>
        {
            bus.AddConsumer<PartnerAConsumer>();
            bus.AddConsumer<PartnerBConsumer>();

            bus.UsingInMemory((context, cfg) =>
            {
                cfg.ConfigureEndpoints(context);
            });
        });

        return services;
    }
}
