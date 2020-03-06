using System;
using System.Collections.Generic;
using System.Text;
using Skr3D.Domain.Models;

namespace Skr3D.Domain.Interfaces
{
    /// <summary>
    /// IOrderRepository接口
    /// 注意，这里我们的对象，是领域对象
    /// </summary>
    public interface IOrderRepository : IRepository<Order>
    {
        //一些Student独有的接口
        Order GetByName(string name);
    }
}
