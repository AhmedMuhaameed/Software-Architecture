using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Component_Diagram
{
    public class OrderProcessingComponent : IOrderService
    {
        private readonly IPaymentService _paymentService;

        public OrderProcessingComponent(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessOrder(int orderId)
        {
            _paymentService.ProcessPayment(100.0m);
        }
    }
}
