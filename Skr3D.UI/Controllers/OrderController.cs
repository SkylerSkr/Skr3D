using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Skr3D.Application.Services;
using Skr3D.Application.ViewModels;
using Skr3D.Domain.EventHandlers.Notifications;
using Skr3D.Domain.Events.Notifications;

namespace Skr3D.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAppService _OrderAppService;

        private readonly DomainNotificationHandler _notification;


        public OrderController(IOrderAppService OrderAppService, INotificationHandler<DomainNotification> notification)
        {
            _OrderAppService = OrderAppService;
            _notification = (DomainNotificationHandler) notification;
        }

        // GET: Order
        public object Index()
        {
            var result = _OrderAppService.GetAll();
            return result;
        }

        // POST: Order/Create
        // 方法
        [HttpPost("Create")]
        //[ValidateAntiForgeryToken]
        public object Create([FromBody]OrderViewModel OrderViewModel)
        {
            // 视图模型验证
            if (!ModelState.IsValid)
                return false;

            // 这里为了测试，手动赋值items
            OrderViewModel.Items = new List<OrderItemViewModel>() {
                    new OrderItemViewModel (){
                        Name="详情"+DateTime.Now
                    }
                };

            // 执行添加方法
            _OrderAppService.Register(OrderViewModel);

            if (_notification.HasNotifications())
            {
                return _notification.GetNotifications();
            }

            return true;
        }


    }
}
