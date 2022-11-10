using DotNetCore.CAP;
using MediatR;
using Order.Application.Command.Request;
using Order.Application.Command.Response;
using Order.Application.Events;
using Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Handlers.Command
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly ICapPublisher _eventBus;

        public CreateOrderCommandHandler(ICapPublisher eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            OrderCreatedEvent @event = new OrderCreatedEvent()
            {
                Id = request.Id,
                ProductId = request.ProductId,
                Quantity = request.Quantity
            };
            //domain ruleları ile valide edilen domain instance ı sonucunda kendisini döner.
            var order = new Domain.OrderAggregate.Order();
            order.CreateOrder(request.Id, request.ProductId, request.Quantity);

            //repostitory.CreateOrder(order);
            try
            {
                _eventBus.Publish(nameof(OrderCreatedEvent), @event);
            }
            catch (Exception ex)
            {

                throw;
            }

            CreateOrderCommandResponse createOrderCommandResponse = new CreateOrderCommandResponse()
            {
                IsSuccess = true
            };

            return createOrderCommandResponse;
        }
    }
}
