using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Skr3D.Application.ViewModels;
using Skr3D.Domain.Commands.Order;
using Skr3D.Domain.Models;

namespace Skr3D.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //手动进行配置
            CreateMap<OrderViewModel, Order>()
                .ForPath(d => d.Address.Province, o => o.MapFrom(s => s.Province))
                .ForPath(d => d.Address.City, o => o.MapFrom(s => s.City))
                .ForPath(d => d.Address.County, o => o.MapFrom(s => s.County))
                .ForPath(d => d.Address.Street, o => o.MapFrom(s => s.Street))
                .ForPath(d=>d.OrderItem,o=>o.MapFrom(s=>s.Items));

            CreateMap<OrderItemViewModel, OrderItem>();


            CreateMap<OrderViewModel, RegisterOrderCommand>()
                .ForPath(d => d.Address.Province, o => o.MapFrom(s => s.Province))
                .ForPath(d => d.Address.City, o => o.MapFrom(s => s.City))
                .ForPath(d => d.Address.County, o => o.MapFrom(s => s.County))
                .ForPath(d => d.Address.Street, o => o.MapFrom(s => s.Street))
                .ForPath(d => d.OrderItem, o => o.MapFrom(s => s.Items));
        }
    }
}

