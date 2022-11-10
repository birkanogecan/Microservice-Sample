using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.OrderAggregate
{
    public class Order : AggregateRoot
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public void CreateOrder(int orderId, int productId, int quantity)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Quantity = quantity;
        }
    }
}
