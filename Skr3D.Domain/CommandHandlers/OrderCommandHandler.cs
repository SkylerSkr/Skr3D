using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skr3D.Domain.Commands.Order;
using Skr3D.Domain.Core.Bus;
using Skr3D.Domain.Interfaces;
using Skr3D.Domain.Models;

namespace Skr3D.Domain.CommandHandlers
{
    /// <summary>
    /// Order命令处理程序
    /// 用来处理该Order下的所有命令
    /// 注意必须要继承接口IRequestHandler<,>，这样才能实现各个命令的Handle方法
    /// </summary>
    public class OrderCommandHandler : CommandHandler,
        IRequestHandler<RegisterOrderCommand, Unit>
    {
        // 注入仓储接口
        private readonly IOrderRepository _OrderRepository;
        // 注入总线
        private readonly IMediatorHandler Bus;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="OrderRepository"></param>
        /// <param name="uow"></param>
        /// <param name="bus"></param>
        /// <param name="cache"></param>
        public OrderCommandHandler(IOrderRepository OrderRepository,
            IMediatorHandler bus
        ) : base( bus)
        {
            _OrderRepository = OrderRepository;
            Bus = bus;
        }


        // RegisterOrderCommand命令的处理程序
        // 整个命令处理程序的核心都在这里
        // 不仅包括命令验证的收集，持久化，还有领域事件和通知的添加
        public Task<Unit> Handle(RegisterOrderCommand message, CancellationToken cancellationToken)
        {

            // 实例化领域模型，这里才真正的用到了领域模型
            // 注意这里是通过构造函数方法实现

            var Order = new Order(Guid.NewGuid(), message.Name, message.Address, message.OrderItem);


            // 持久化
            _OrderRepository.Add(Order);

            _OrderRepository.SaveChanges();


            return Task.FromResult(new Unit());

        }


        // 手动回收
        public void Dispose()
        {
            _OrderRepository.Dispose();
        }
    }
}
