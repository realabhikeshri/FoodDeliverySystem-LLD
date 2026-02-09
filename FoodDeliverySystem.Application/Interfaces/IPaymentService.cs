namespace FoodDeliverySystem.Application.Interfaces
{
    public interface IPaymentService
    {
        bool ProcessPayment(Guid orderId, decimal amount);
    }
}