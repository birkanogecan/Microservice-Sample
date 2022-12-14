using DotNetCore.CAP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Application.Events;
using Order.Application.Command.Request;

namespace Order.Consumer.EventHandlers
{
    public class CheckoutCompletedEventHandler : ICapSubscribe
    {
        IMediator _mediator;

        public CheckoutCompletedEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        [CapSubscribe(nameof(CheckoutCompletedEvent))]
        public async Task Handle(CheckoutCompletedEvent @event)
        {
            CreateOrderCommandRequest createOrderCommandRequest = new CreateOrderCommandRequest() { Id = @event.Id, ProductId = @event.ProductId , Quantity = @event.Quantity };
            var response = _mediator.Send(createOrderCommandRequest);
        }
    }
}
