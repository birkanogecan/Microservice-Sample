using Order.Core.Command.Request;
using Order.Core.Command.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service.BLL.Impl
{
    public interface IOrderService
    {
        CreateOrderCommandResponse CreateOrder(CreateOrderCommandRequest request);
    }
}
