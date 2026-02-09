using FoodDeliverySystem.Application.Services;
using FoodDeliverySystem.Domain.Entities;
using FoodDeliverySystem.Infrastructure.Payments;
using FoodDeliverySystem.Infrastructure.Repositories;


var customer = new Customer("Abhishek", "9999999999");


var restaurant = new Restaurant("Pizza Palace");
restaurant.AddMenuItem(new MenuItem("Margherita", 299));
restaurant.AddMenuItem(new MenuItem("Farmhouse", 399));


var orderRepo = new InMemoryOrderRepository();
var paymentService = new DummyPaymentService();
var orderService = new OrderService(orderRepo, paymentService);


var order = orderService.PlaceOrder(customer, restaurant, restaurant.Menu);
Console.WriteLine($"Order placed with ID: {order.Id}");