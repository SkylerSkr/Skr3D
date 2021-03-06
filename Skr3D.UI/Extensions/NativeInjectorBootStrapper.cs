﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Skr3D.Application.Services;
using Skr3D.Domain.CommandHandlers;
using Skr3D.Domain.Commands.Order;
using Skr3D.Domain.Core.Bus;
using Skr3D.Domain.EventHandlers;
using Skr3D.Domain.EventHandlers.Notifications;
using Skr3D.Domain.EventHandlers.Order;
using Skr3D.Domain.Events;
using Skr3D.Domain.Events.Notifications;
using Skr3D.Domain.Events.Order;
using Skr3D.Domain.Interfaces;
using Skr3D.Infrastruct.Data.Context;
using Skr3D.Infrastruct.Data.Repository;

namespace Skr3D.UI.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // 注入 应用层Application
            services.AddScoped<IOrderAppService, OrderAppService>();

            //命令总线Domain Bus(Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();


            // 领域层 - 领域命令
            // 将命令模型和命令处理程序匹配
            services.AddScoped<IRequestHandler<RegisterOrderCommand, Unit>, OrderCommandHandler>();

            // 领域事件
            services.AddScoped<INotificationHandler<RegisterOrderEvent>, OrderEventHandler>();

            // 领域通知
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();


            // 领域层 - Memory
            services.AddSingleton<IMemoryCache>(factory =>
            {
                var cache = new MemoryCache(new MemoryCacheOptions());
                return cache;
            });



            // 注入 基础设施层 - 数据层
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<OrderContext>();
        }
    }
}
