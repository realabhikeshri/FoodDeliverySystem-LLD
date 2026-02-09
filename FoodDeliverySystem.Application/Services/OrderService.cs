using FoodDeliverySystem.Application.Interfaces;
using FoodDeliverySystem.Domain.Entities;
using FoodDeliverySystem.Domain.Enums;


namespace FoodDeliverySystem.Application.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPaymentService _paymentService;


        public OrderService(IOrderRepository repo, IPaymentService paymentService)
        {
            _orderRepository = repo;
            _paymentService = paymentService;
        }


        public Order PlaceOrder(Customer customer, Restaurant restaurant, List<MenuItem> items)
        {
            var order = new Order(customer, restaurant, items);


            var paymentSuccess = _paymentService.ProcessPayment(order.Id, order.TotalAmount());
            if (!paymentSuccess)
                throw new Exception("Payment Failed");


            _orderRepository.Save(order);
            return order;
        }


        public void UpdateOrderStatus(Guid orderId, OrderStatus status)
        {
            var order = _orderRepository.GetById(orderId);
            order.UpdateStatus(status);
        }
    }
}