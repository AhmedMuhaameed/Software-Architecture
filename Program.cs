// See https://aka.ms/new-console-template for more information
using Software_Architecture.UML_Component_Diagram;
using Software_Architecture.UML_Relations.Composition;
using static Software_Architecture.UML_Relations.Composition.House;

Console.WriteLine("Hello, World!");


var paymentComponent = new PaymentGatewayComponent();
var orderComponent = new OrderProcessingComponent(paymentComponent);
var customerComponent = new CustomerServiceComponent(orderComponent);
customerComponent.PlaceOrder(123);
