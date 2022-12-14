using MediatR;
using Order.Application.Command.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Command.Request
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
