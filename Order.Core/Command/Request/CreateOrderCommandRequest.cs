using MediatR;
using Order.Core.Command.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Core.Command.Request
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
