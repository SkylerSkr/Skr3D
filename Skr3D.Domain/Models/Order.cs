using Skr3D.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skr3D.Domain.Models
{
    public class Order : Entity
    {
        protected Order()
        {
        }
        public Order(Guid id, string name,Address address, List<OrderItem> orderItem)
        {
            Id = id;
            Name = name;
            Address = address;
            OrderItem = orderItem;
        }
        /// <summary>
        /// 订单名
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 收获地址
        /// </summary>
        public Address Address { get; private set; }

        /// <summary>
        /// 订单详情
        /// </summary>
        public virtual ICollection<OrderItem> OrderItem { get; private set; }



    }
}
