using System;
using System.Collections.Generic;
using System.Text;
using Skr3D.Domain.Core.Commands;
using Skr3D.Domain.Models;

namespace Skr3D.Domain.Commands.Order
{
    /// <summary>
    /// 定义一个抽象的 Order 命令模型
    /// 继承 Command
    /// 这个模型主要作用就是用来创建命令动作的，所以是一个抽象类
    /// </summary>
    public abstract class OrderCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public List<OrderItem> OrderItem { get; set; }
        public Address Address { get;set; }

    }
}
