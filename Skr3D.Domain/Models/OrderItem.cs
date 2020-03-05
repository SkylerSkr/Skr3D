using System;
using System.Collections.Generic;
using System.Text;
using Skr3D.Domain.Core.Models;

namespace Skr3D.Domain.Models
{
    public class OrderItem : Entity
    {

        /// <summary>
        /// 详情名
        /// </summary>
        public string Name { get; private set; }

        public virtual Order Order { get; set; }
    }
}
