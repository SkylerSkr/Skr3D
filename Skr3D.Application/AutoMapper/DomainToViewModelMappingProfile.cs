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
            CreateMap<Order, OrderViewModel>()
                .ForPath(d => d.Province, o => o.MapFrom(s => s.Address.Province))
                .ForPath(d => d.City, o => o.MapFrom(s => s.Address.City))
                .ForPath(d => d.County, o => o.MapFrom(s => s.Address.County))
                .ForPath(d => d.Street, o => o.MapFrom(s => s.Address.Street)); ;

            CreateMap<OrderItem, OrderItemViewModel>();

        }
    }
}
