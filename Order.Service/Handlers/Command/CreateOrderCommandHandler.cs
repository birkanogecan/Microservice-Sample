using MediatR;
using Order.Core.Command.Request;
using Order.Core.Command.Response;
using Order.Service.BLL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service.Handlers.Command
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private IOrderService _orderService;
        public CreateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            return _orderService.CreateOrder(request);
        }
    }
}
