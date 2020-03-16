using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skr3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skr3D.Infrastruct.Data.Mappings
{

    /// <summary>
    /// 订单map类
    /// </summary>
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        /// <summary>
        /// 实体属性配置
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //实体属性Maps
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            //子订单
            builder.HasMany(c=>c.OrderItem);

            //值类型
            builder.OwnsOne(x=>x.Address);

        }
    }
}
