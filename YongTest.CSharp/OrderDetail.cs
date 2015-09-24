using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YongTest.CSharp
{
    public class OrderDetail
    {
        public int OrderId { get; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderDetail(int orderId)
        {
            this.OrderId = orderId;
        }
    }
}
