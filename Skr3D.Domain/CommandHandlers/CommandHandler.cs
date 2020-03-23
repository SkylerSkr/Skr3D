using System;
using System.Collections.Generic;
using System.Text;
using Skr3D.Domain.Core.Bus;
using Skr3D.Domain.Core.Commands;

namespace Skr3D.Domain.CommandHandlers
{
    /// <summary>
    /// 领域命令处理程序
    /// 用来作为全部处理程序的基类，提供公共方法和接口数据
    /// </summary>
    public class CommandHandler
    {

        // 注入中介处理接口（目前用不到，在领域事件中用来发布事件）
        private readonly IMediatorHandler _bus;


        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="bus"></param>
        /// <param name="cache"></param>
        public CommandHandler( IMediatorHandler bus)
        {
            _bus = bus;
        }
    }
}
