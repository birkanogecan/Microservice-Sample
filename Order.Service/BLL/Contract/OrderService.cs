using DotNetCore.CAP;
using Order.Core.Command.Request;
using Order.Core.Command.Response;
using Order.Core.Events;
using Order.Service.BLL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service.BLL.Contract
{
    public class OrderService : IOrderService
    {
        private readonly ICapPublisher _eventBus;

        public OrderService(ICapPublisher eventBus)
        {
                _eventBus = eventBus;
        }
        public CreateOrderCommandResponse CreateOrder(CreateOrderCommandRequest request)
        {
            OrderCreatedEvent @event = new OrderCreatedEvent()
            {
                Id = request.Id,
                ProductId = request.ProductId,
                Quantity = request.Quantity
            };
            //business işlemleri
            try
            {
                _eventBus.Publish(nameof(OrderCreatedEvent), @event);
            }
            catch (Exception ex)
            {

                throw;
            }
            

            return new CreateOrderCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
