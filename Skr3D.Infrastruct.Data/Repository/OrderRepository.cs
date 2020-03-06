using Skr3D.Domain.Interfaces;
using Skr3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skr3D.Infrastruct.Data.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public Order GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
