using System;
using System.Collections.Generic;
using System.Text;
using Skr3D.Domain.Models;

namespace Skr3D.Domain.Commands.Order
{
    /// <summary>
    /// 注册一个添加 Order 命令
    /// 基础抽象学生命令模型
    /// </summary>
    public class RegisterOrderCommand : OrderCommand
    {
        public RegisterOrderCommand()
        {

        }
        // set 受保护，只能通过构造函数方法赋值
        public RegisterOrderCommand(string name, List<OrderItem> items, Address address)
        {
            Name = name;
            OrderItem = items;
            Address = address;
        }

    }
}
