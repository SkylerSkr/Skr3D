using Skr3D.Domain.Interfaces;
using Skr3D.Domain.Models;
using Skr3D.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skr3D.Infrastruct.Data.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext context)
          : base(context)
        {

        }
        public Order GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
