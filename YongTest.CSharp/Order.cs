using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YongTest.CSharp
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderDetail> Details { get; } = new List<OrderDetail>();

        public Order AddDetail(string item, int quantity, decimal price) {
            Details.Add(new OrderDetail(OrderId = this.OrderId) { Item = item, Quantity = quantity, Price = price });
            return this;
        }

        public decimal GetOrderTotalAmount() => 
            Details.Sum(x => x.Price * x.Quantity);

        public List<OrderDetail> FindItem(string item) =>
            Details.Where(x => x.Item == item).ToList();
        public override string ToString() => $"{CustomerName} Order {OrderId.ToString("0")}";
       
    }

    public static class OrderExtension
    {
        public static void ChangeCustomerName(this Order order, string name)
        {
            order.CustomerName = name;
        }
    }
}
