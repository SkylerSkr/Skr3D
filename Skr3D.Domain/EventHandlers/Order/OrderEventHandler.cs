using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skr3D.Domain.Events.Order;

namespace Skr3D.Domain.EventHandlers.Order
{
    public class OrderEventHandler : INotificationHandler<RegisterOrderEvent>
    {
        public Task Handle(RegisterOrderEvent notification, CancellationToken cancellationToken)
        {
            // 恭喜您，注册成功，欢迎加入我们。

            return Task.CompletedTask;
        }
    }
}
