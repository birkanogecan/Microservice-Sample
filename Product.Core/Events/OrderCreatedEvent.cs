using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Events
{
    public class OrderCreatedEvent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
