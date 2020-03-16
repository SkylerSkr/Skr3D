using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Skr3D.Application.ViewModels;
using Skr3D.Domain.Models;

namespace Skr3D.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderItem, OrderItemViewModel>();
           // CreateMap<OrderItemViewModel, OrderItem>();

        }
    }
}
