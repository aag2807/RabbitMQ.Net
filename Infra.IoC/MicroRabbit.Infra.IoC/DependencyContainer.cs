using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Domain.Core.Events;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Infra.Bus;


namespace MicroRabbit.Infra.IoC;
public class DependencyContainer
{

    public static void RegisterServices(IServiceCollection services)
    {
        //DOMAIN BUS
        services.AddTransient<IEventBus, RabbitMQBus>();
    }

}