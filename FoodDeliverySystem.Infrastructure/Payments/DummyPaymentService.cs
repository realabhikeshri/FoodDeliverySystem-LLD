using FoodDeliverySystem.Application.Interfaces;


namespace FoodDeliverySystem.Infrastructure.Payments
{
    public class DummyPaymentService : IPaymentService
    {
        public bool ProcessPayment(Guid orderId, decimal amount)
        {
            Console.WriteLine($"Payment of ₹{amount} successful for Order {orderId}");
            return true;
        }
    }
}