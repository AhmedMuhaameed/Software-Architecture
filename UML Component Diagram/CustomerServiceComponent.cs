using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Component_Diagram
{
    public class CustomerServiceComponent
    {
        private readonly IOrderService _orderService;
        public CustomerServiceComponent(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void PlaceOrder(int orderId)
        {
            _orderService.ProcessOrder(orderId);
        }
    }
}
