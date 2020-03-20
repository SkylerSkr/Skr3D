using Skr3D.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Skr3D.Application.ViewModels;
using Skr3D.Domain.Models;

namespace Skr3D.Application.Services
{
    /// <summary>
    /// OrderAppService 服务接口实现类, 继承 服务接口
    /// 通过 DTO 实现视图模型和领域模型的关系处理
    /// 作为调度者，协调领域层和基础层，
    /// 这里只是做一个面向用户用例的服务接口,不包含业务规则或者知识
    /// </summary>
    public class OrderAppService : IOrderAppService
    {
        // 注意这里是要IoC依赖注入的，还没有实现
        private readonly IOrderRepository _OrderRepository;
        // 用来进行DTO
        private readonly IMapper _mapper;

        public OrderAppService(
            IOrderRepository OrderRepository,
            IMapper mapper
        )
        {
            _OrderRepository = OrderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderViewModel> GetAll()
        {
            var orders = _OrderRepository.GetAll();
            var orderList = orders.ToList();
            return _mapper.Map<IEnumerable<OrderViewModel>>(orders);
        }

        public OrderViewModel GetById(Guid id)
        {
            return _mapper.Map<OrderViewModel>(_OrderRepository.GetById(id));
        }

        public void Register(OrderViewModel OrderViewModel)
        {
            var order = _mapper.Map<Order>(OrderViewModel);
            _OrderRepository.Add(order);
            _OrderRepository.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
